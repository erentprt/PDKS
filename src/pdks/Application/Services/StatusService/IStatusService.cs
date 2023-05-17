using Domain.Entities;

namespace Application.Services.StatusService;

public interface IStatusService
{
    public Task<DailyReport> UpdateNumberOfEmployeesInTheWorkplace(DateTime date);
    public Task<DailyReport> UpdateNumberOfEmployeesNotAtWork(DateTime date);
    public Task<DailyReport> UpdateMoneyPaidToday(DateTime dateTime, int amount);
    public Task<DailyReport> CheckIfDailyReportExists(DateTime date);
}