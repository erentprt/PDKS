using Application.Services.LoginAndExitService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DailyReports.Queries.GetByDate;

public class GetByDateDailyReportQuery:IRequest<GetByDateDailyReportQueryResponse>
{
    public int Id { get; set; }
}

public class GetByDateDailyReportQueryHandler:IRequestHandler<GetByDateDailyReportQuery,GetByDateDailyReportQueryResponse>
{
    private readonly IDailyReportRepository _dailyReportRepository;
    private readonly IMapper _mapper;
    private readonly ILoginAndExitService _loginAndExitService;
    private readonly IEmployeeRepository _employeeRepository;
    public GetByDateDailyReportQueryHandler(IDailyReportRepository dailyReportRepository, IMapper mapper, ILoginAndExitService loginAndExitService, IEmployeeRepository employeeRepository)
    {
        _dailyReportRepository = dailyReportRepository;
        _mapper = mapper;
        _loginAndExitService = loginAndExitService;
        _employeeRepository = employeeRepository;
    }

    public async Task<GetByDateDailyReportQueryResponse> Handle(GetByDateDailyReportQuery request, CancellationToken cancellationToken)
    {
        var employeeList = await _employeeRepository.GetListAsync();
        var dailyReport = await _dailyReportRepository.GetAsync(x=>x.Id == request.Id);
        var date = dailyReport!.Date;
        var loginList = await _loginAndExitService.GetByDate(date); // o gün giriş yapanların listesi
        
        var loginEmployeeList = employeeList.Items
            .Where(employee => loginList.Any(login => login.EmployeeCode == employee.EmployeeCode))
            .ToList();

        var notLoginEmployeeList = employeeList.Items
            .Where(employee => !loginEmployeeList.Contains(employee))
            .ToList();
        
        GetByDateDailyReportQueryResponse getByDateDailyReportQueryResponse = new()
        {
            LoggedInEmployees = loginEmployeeList,
            NotLoggedInEmployees = notLoginEmployeeList
        };
    
        
        
        
        return getByDateDailyReportQueryResponse;
    }
}
