using Domain.Entities;

namespace Application.Services.DailyReportService;

public interface IDailyReportService
{
    public Task<DailyReport> UpdateNumberOfEmployeesInTheWorkplace(DateTime date);
    public Task<DailyReport> UpdateNumberOfEmployeesNotAtWork(DateTime date);
    public Task<DailyReport> UpdateMoneyPaidToday(DateTime dateTime, int amount);
}