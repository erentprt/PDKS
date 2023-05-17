using Microsoft.Extensions.Hosting;

namespace Application.Services.BackgroundServices;

public class DailyReportCreator : IHostedService
{
    private Timer timer;

    public Task StartAsync(CancellationToken cancellationToken)
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

    private async void CreateDailyReport(object state)
    {
        Console.WriteLine($"{DateTime.Now.ToLongTimeString()}");
        using HttpClient client = new HttpClient();
        HttpResponseMessage response =
            await client.GetAsync("https://localhost:44329/DailyReport/CreateDailyReport");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }

}