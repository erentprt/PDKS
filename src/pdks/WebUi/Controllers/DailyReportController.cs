using Application.Features.DailyReports.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers;

public class DailyReportController:BaseController
{
    
    [HttpGet]
    public async Task<IActionResult> CreateDailyReport(CreateDailyReportCommand createDailyReportCommand)
    {
        var response = await Mediator.Send(createDailyReportCommand);
        return Ok(response);
    }
}