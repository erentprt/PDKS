using Application.Features.LoginAndExits.Rules;
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
    public LoginToCompanyCommandHandler(ILoginAndExitRepository loginAndExitRepository, IMapper mapper, IEmployeeService employeeService, LoginAndExitBusinessRules loginAndExitBusinessRules)
    {
        _loginAndExitRepository = loginAndExitRepository;
        _mapper = mapper;
        _employeeService = employeeService;
        _loginAndExitBusinessRules = loginAndExitBusinessRules;
    }

    public async Task<LoginToCompanyResponse> Handle(LoginToCompanyCommand request, CancellationToken cancellationToken)
    {
        var employee = await _employeeService.GetByEmployeeCode(request.EmployeeCode);
        await _loginAndExitBusinessRules.IsEmployeeCodeNoteExist(request.EmployeeCode);
        var uid = employee.Id + "_" + DateTime.UtcNow.ToString("yyyy-MM-dd");
        LoginAndExit? lae = await _loginAndExitRepository.GetAsync(le=>le.Userid_Date==uid);
        await _loginAndExitBusinessRules.EmployeeIsAlreadyLoginAndExit(lae);
        
        if (lae == null)
        {
            LoginAndExit loginAndExit = new()
            {
                EmployeeCode = request.EmployeeCode,
                LoginTime = DateTime.UtcNow,
                Userid_Date = uid
            };
            await _employeeService.SetAtWork(employee.Id, true);
            await _loginAndExitRepository.AddAsync(loginAndExit);
        }
        else if (lae.ExitTime is null)
        {
            await _employeeService.SetDailyExit(employee.Id, false,
                (int)(DateTime.UtcNow - lae.LoginTime).TotalHours * employee.HourlySalary!.Value,
                (int)(DateTime.UtcNow - lae.LoginTime).TotalHours);
            lae.ExitTime = DateTime.UtcNow;
            await _loginAndExitRepository.UpdateAsync(lae);
        }
        LoginToCompanyResponse loginToCompanyResponse = _mapper.Map<LoginToCompanyResponse>(lae);
        return loginToCompanyResponse;
    }
}