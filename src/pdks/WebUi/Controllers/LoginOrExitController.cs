using Application.Features.LoginAndExits.Commands.LoginToCompany;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace WebUi.Controllers;

public class LoginOrExitController:BaseController
{
    private readonly IToastNotification _toastNotification;

    public LoginOrExitController(IToastNotification toastNotification)
    {
        _toastNotification = toastNotification;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View("Index");
    }
    
    [HttpPost]
    public async Task<IActionResult> LoginOrExitCompany(LoginToCompanyCommand command)
    {
        var response = await Mediator.Send(command);
        if (response.Userid_Date == null)
        {
            _toastNotification.AddErrorToastMessage("Something went wrong");
        }
        else
        {
            _toastNotification.AddSuccessToastMessage($"{response.EmployeeCode} logged out successfully");
        }

        return View("Index");
    }
}