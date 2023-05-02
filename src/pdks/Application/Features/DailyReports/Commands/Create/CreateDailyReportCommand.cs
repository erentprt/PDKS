using Application.Features.DailyReports.Rules;
using Application.Services.DailyReportService;
using Application.Services.EmployeeService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DailyReports.Commands.Create;

public class CreateDailyReportCommand:IRequest<CreatedDailyReportResponse>
{
}

public class CreateDailyReportCommandHandler : IRequestHandler<CreateDailyReportCommand, CreatedDailyReportResponse>
{
    private readonly IDailyReportRepository _dailyReportRepository;
    private readonly IMapper _mapper;
    private readonly DailyReportBusinessRules _dailyReportBusinessRules;
    private readonly IEmployeeService _employeeService;
    

    public CreateDailyReportCommandHandler(IDailyReportRepository dailyReportRepository, IMapper mapper, DailyReportBusinessRules dailyReportBusinessRules, IEmployeeService employeeService)
    {
        _dailyReportRepository = dailyReportRepository;
        _mapper = mapper;
        _dailyReportBusinessRules = dailyReportBusinessRules;
        _employeeService = employeeService;
    }

    public async Task<CreatedDailyReportResponse> Handle(CreateDailyReportCommand request, CancellationToken cancellationToken)
    {
        var dateNow = DateTime.UtcNow;
        await _dailyReportBusinessRules.DailyReportExists(dateNow);
        var totalEmployee = await _employeeService.GetEmployeeCount();
        DailyReport dailyReport = new DailyReport();
        dailyReport.TotalNumberOfEmployees = totalEmployee;
        dailyReport.NumberOfEmployeesNotAtWork = totalEmployee;
        dailyReport.Date = dateNow;
        await _dailyReportRepository.AddAsync(dailyReport);
        return _mapper.Map<CreatedDailyReportResponse>(dailyReport);
    }
}