using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Application.Services.BackgroundServices;

public class DailyReportCreator : IHostedService
{
    public  Task StartAsync(CancellationToken cancellationToken)
    {
  
        /*
        Console.WriteLine($"{nameof(DailyReportCreator)} service started");
        timer = new Timer(CreateDailyReport, null, TimeSpan.Zero, TimeSpan.FromHours(24));
        */
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"{nameof(DailyReportCreator)} service stopped");
        return Task.CompletedTask;
    }
    

}