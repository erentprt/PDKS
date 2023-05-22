using Application.Features.DailyReports.Commands.Create;
using Application.Features.DailyReports.Queries.GetByDate;
using Application.Features.DailyReports.Queries.GetList;
using Application.Features.DailyReports.Rules;
using Application.Services.EmployeeService;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Domain.Entities;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers;

public class DailyReportController:BaseController
{
    private readonly IDashboardRepository _dashboardRepository;
    private readonly IDailyReportRepository _dailyReportRepository;
    private readonly IMapper _mapper;
    private readonly DailyReportBusinessRules _dailyReportBusinessRules;
    private readonly IEmployeeService _employeeService;

    public DailyReportController(IDashboardRepository dashboardRepository, IDailyReportRepository dailyReportRepository, IMapper mapper, DailyReportBusinessRules dailyReportBusinessRules, IEmployeeService employeeService)
    {
        _dailyReportRepository = dailyReportRepository;
        _mapper = mapper;
        _dailyReportBusinessRules = dailyReportBusinessRules;
        _employeeService = employeeService;
        _dashboardRepository = dashboardRepository;
    }

    [HttpGet]
    public  IActionResult CreateDailyReport(CreateDailyReportCommand createDailyReportCommand)
    {
        RecurringJob.AddOrUpdate(  ()=>  CreateDailyReport(),Cron.Daily(00,00));
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> Index([FromQuery] PageRequest pageRequest)
    {
        GetListDailyReportQuery getListModelQuery = new() { PageRequest = new PageRequest(){Page = pageRequest.Page,PageSize = pageRequest.PageSize} };
        var response = await Mediator.Send(getListModelQuery);
        return View("Index",response);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetByDate(GetByDateDailyReportQuery getByDateDailyReportQuery)
    {
        var response = await Mediator.Send(getByDateDailyReportQuery);
        return View("GetByDate",response);
    }

    public void CreateDailyReport()
    {
        var dateNow = DateTime.UtcNow;
        //_dailyReportBusinessRules.DailyReportExists(dateNow);
        var totalEmployee =  _employeeService.GetAllEmployeeCount().Result;
        DailyReport dailyReport = new DailyReport();
        dailyReport.TotalNumberOfEmployees = totalEmployee;
        dailyReport.NumberOfEmployeesNotAtWork = totalEmployee;
        dailyReport.Date = dateNow;
        _dailyReportRepository.Add(dailyReport);
        _employeeService.UpdateAllEmployeeAtWorkFalse();
    }
}
