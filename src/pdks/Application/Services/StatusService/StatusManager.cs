using Application.Services.DailyReportService;
using Application.Services.Repositories;
using Domain.Entities;

namespace Application.Services.StatusService;

public class StatusManager:IStatusService
{
    private readonly IDailyReportRepository _dailyReportRepository;


    public StatusManager(IDailyReportRepository dailyReportRepository)
    {
        _dailyReportRepository = dailyReportRepository;
    }

    public async Task<DailyReport> UpdateNumberOfEmployeesInTheWorkplace(DateTime date)
    {
        var dailyReport = await _dailyReportRepository.GetAsync(x => x.Date.Date== date.Date);
        dailyReport!.NumberOfEmployeesInTheWorkplace++;
        dailyReport.NumberOfEmployeesNotAtWork--;
        await _dailyReportRepository.UpdateAsync(dailyReport);
        return dailyReport;
    }

    public async Task<DailyReport> UpdateNumberOfEmployeesNotAtWork(DateTime date)
    {
        var dailyReport = await _dailyReportRepository.GetAsync(x => x.Date.Date== date.Date);
        dailyReport!.NumberOfEmployeesInTheWorkplace--;
        dailyReport.NumberOfEmployeesNotAtWork++;
        await _dailyReportRepository.UpdateAsync(dailyReport);
        return dailyReport;
    }
    

    public async Task<DailyReport> UpdateMoneyPaidToday(DateTime date,int amount)
    {
        var dailyReport = await _dailyReportRepository.GetAsync(x => x.Date.Date== date.Date);
        dailyReport!.MoneyPaidToday += amount;
        await _dailyReportRepository.UpdateAsync(dailyReport);
        return dailyReport;
    }

    public async Task<DailyReport?> CheckIfDailyReportExists(DateTime date)
    {
        var dailyReport = await _dailyReportRepository.GetAsync(x => x.Date.Date== date.Date);
        if (dailyReport == null)
            return null;
            
        
        return dailyReport;
    }
}