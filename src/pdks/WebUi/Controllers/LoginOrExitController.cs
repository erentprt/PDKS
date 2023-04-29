using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers;

public class LoginOrExitController:BaseController
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View("Index");
    }
}