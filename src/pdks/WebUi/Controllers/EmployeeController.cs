using Application.Features.Employees.Commands.Create;
using Application.Features.Employees.Commands.Delete;
using Application.Features.Employees.Commands.Update;
using Application.Features.Employees.Queries.GetById;
using Application.Features.Employees.Queries.GetList;
using Application.Features.Employees.Queries.GetListAtWork;
using Application.Features.Employees.Queries.GetListNotAtWork;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers;

public class EmployeeController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Index([FromQuery] PageRequest pageRequest)
    {
        GetListEmployeeQuery getListModelQuery = new() { PageRequest = new PageRequest(){Page = pageRequest.Page,PageSize = pageRequest.PageSize} };
        GetListResponse<GetListEmployeeListItemDto> result = await Mediator.Send(getListModelQuery);
        return View(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand createEmployeeCommand)
    {
        var result = await Mediator.Send(createEmployeeCommand);
        var employeeList = await Mediator.Send(new GetListEmployeeQuery() {PageRequest = new PageRequest(){Page = 0,PageSize = 5}});
        return View("Index",employeeList);
    }
    
    [HttpPost]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var result = await Mediator.Send(new DeleteEmployeeCommand(id));
        var employeeList = await Mediator.Send(new GetListEmployeeQuery() {PageRequest = new PageRequest(){Page = 0,PageSize = 5}});
        return View("Index",employeeList);
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdEmployee(int id)
    {
        var result = await Mediator.Send(new GetByIdEmployeeQuery(id));
        return View("UpdateEmployee",result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommand updateEmployeeCommand)
    {
        var result = await Mediator.Send(updateEmployeeCommand);
        var departmentList = await Mediator.Send(new GetListEmployeeQuery() {PageRequest = new PageRequest(){Page = 0,PageSize = 5}});
        return View("Index",departmentList);

    }
    
    [HttpGet]
    public async Task<IActionResult> AtWork([FromQuery] PageRequest pageRequest)
    {
        GetListAtWorkQuery getListModelQuery = new() { PageRequest = new PageRequest(){Page = pageRequest.Page,PageSize = pageRequest.PageSize} };
        GetListResponse<GetListAtWorkListItemDto> result = await Mediator.Send(getListModelQuery);
        return View(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> NotAtWork([FromQuery] PageRequest pageRequest)
    {
        GetListNotAtWorkQuery getListModelQuery = new() { PageRequest = new PageRequest(){Page = pageRequest.Page,PageSize = pageRequest.PageSize} };
        GetListResponse<GetListNotAtWorkListItemDto> result = await Mediator.Send(getListModelQuery);
        return View(result);
    }

}