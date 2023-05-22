using Application.Features.LoginAndExits.Rules;
using Application.Services.DailyReportService;
using Application.Services.EmployeeService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.LoginAndExits.Commands.LoginToCompany;

public class LoginToCompanyCommand:IRequest<LoginToCompanyResponse>
{
    public string EmployeeCode { get; set; }
}

public class LoginToCompanyCommandHandler : IRequestHandler<LoginToCompanyCommand, LoginToCompanyResponse>
{
    private readonly ILoginAndExitRepository _loginAndExitRepository;
    private readonly IMapper _mapper;
    private readonly IEmployeeService _employeeService;
    private readonly LoginAndExitBusinessRules _loginAndExitBusinessRules;
    private readonly IDailyReportService _dailyReportService;
    public LoginToCompanyCommandHandler(ILoginAndExitRepository loginAndExitRepository, IMapper mapper, IEmployeeService employeeService, LoginAndExitBusinessRules loginAndExitBusinessRules, IDailyReportService dailyReportService)
    {
        _loginAndExitRepository = loginAndExitRepository;
        _mapper = mapper;
        _employeeService = employeeService;
        _loginAndExitBusinessRules = loginAndExitBusinessRules;
        _dailyReportService = dailyReportService;
    }

    public async Task<LoginToCompanyResponse> Handle(LoginToCompanyCommand request, CancellationToken cancellationToken)
    {
        var employee = await _employeeService.GetByEmployeeCode(request.EmployeeCode);
        var date = DateTime.UtcNow;
        await _loginAndExitBusinessRules.IsEmployeeCodeNoteExist(request.EmployeeCode);
        var uid = employee.Id + "_" + date.ToString("yyyy-MM-dd");
        LoginAndExit? lae = await _loginAndExitRepository.GetAsync(le=>le.Userid_Date==uid);
        await _loginAndExitBusinessRules.EmployeeIsAlreadyLoginAndExit(lae);
        
        if (lae == null)
        {
            LoginAndExit loginAndExit = new()
            {
                EmployeeCode = request.EmployeeCode,
                LoginTime = date,
                Userid_Date = uid
            };
            await _employeeService.SetAtWork(employee.Id, true);
            await _dailyReportService.UpdateNumberOfEmployeesInTheWorkplace(date.Date);
            await _loginAndExitRepository.AddAsync(loginAndExit);
        }
        else if (lae.ExitTime is null)
        {
            await _employeeService.SetDailyExit(employee.Id, true,
                (int)(date - lae.LoginTime).TotalHours * employee.HourlySalary!.Value,
                (int)(date - lae.LoginTime).TotalHours);
            lae.ExitTime = date;
            //await _dailyReportService.UpdateNumberOfEmployeesNotAtWork(date.Date);
            await _dailyReportService.UpdateMoneyPaidToday(date.Date,
                (int)(date - lae.LoginTime).TotalHours * (int)employee.HourlySalary!.Value);
            await _loginAndExitRepository.UpdateAsync(lae);
        }
        LoginToCompanyResponse loginToCompanyResponse = _mapper.Map<LoginToCompanyResponse>(lae);
        return loginToCompanyResponse;
    }
}