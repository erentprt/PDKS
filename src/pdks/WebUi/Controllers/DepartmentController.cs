using System.Dynamic;
using Application.Features.Departments.Commands.Create;
using Application.Features.Departments.Commands.Delete;
using Application.Features.Departments.Commands.Update;
using Application.Features.Departments.Queries.GetById;
using Application.Features.Departments.Queries.GetList;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers;

public class DepartmentController:BaseController
{
    
    private readonly ILogger<HomeController> _logger;


    public DepartmentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public async Task<IActionResult> Index()
    {
        GetListDepartmentQuery getListModelQuery = new() { PageRequest = new PageRequest(){Page = 0,PageSize = 5} };
        GetListResponse<GetListDepartmentListItemDto> result = await Mediator.Send(getListModelQuery);
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateDepartment(CreateDepartmentCommand createDepartmentCommand)
    {
        var result = await Mediator.Send(createDepartmentCommand);
        var departmentList = await Mediator.Send(new GetListDepartmentQuery() {PageRequest = new PageRequest(){Page = 0,PageSize = 5}});
        return View("Index",departmentList);
    }
    
    //todo mvc için HttpDelete kullanımını araştır (Jquery ile büyük ihtimalle)
    [HttpPost]
    public async Task<IActionResult> DeleteDepartment(int id)
    {
        var result = await Mediator.Send(new DeleteDepartmentCommand(id));
        var departmentList = await Mediator.Send(new GetListDepartmentQuery() {PageRequest = new PageRequest(){Page = 0,PageSize = 5}});
        return View("Index",departmentList);
    }
    
    [HttpPost]
    public async Task<IActionResult> UpdateDepartment(UpdateDepartmentCommand updateDepartmentCommand)
    {
        var result = await Mediator.Send(updateDepartmentCommand);
        var departmentList = await Mediator.Send(new GetListDepartmentQuery() {PageRequest = new PageRequest(){Page = 0,PageSize = 5}});
        return View("Index",departmentList);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetByIdDepartment(int id)
    {
        var result = await Mediator.Send(new GetByIdDepartmentQuery(id));
        return View("UpdateDepartment",result);
    }
    


}