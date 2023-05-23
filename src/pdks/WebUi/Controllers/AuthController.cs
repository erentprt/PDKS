using System.Security.Claims;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers;

public class AuthController : BaseController
{
    private readonly IAdminRepository _adminRepository;

    public AuthController(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Login(Admin admin)
    {
        var adminFromDb = await _adminRepository.GetAsync(x=>x.Email== admin.Email && x.Password == admin.Password);
        if (adminFromDb == null)
        {
            ViewBag.Message = "Email or password is wrong";
            return View("Index");
        }
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, adminFromDb.Email),
            new(ClaimTypes.Role, "Admin")
        };
        var identity = new ClaimsIdentity(claims, "Admin");
        ClaimsPrincipal claimsPrincipal = new(identity);
        await HttpContext.SignInAsync(claimsPrincipal);
        return RedirectToAction("Index", "Home");
    }
    
    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login");
    }
}