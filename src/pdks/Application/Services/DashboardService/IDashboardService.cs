namespace Application.Services.DashboardService;

public interface IDashboardService
{
    Task<int> GetAllEmployeeCount();
    Task<int> GetEmployeesAtWorkCount();
    Task<int> GetEmployeesNotAtWorkCount();
    Task<int> GetEmployeesWithWorkPermitCount();
    Task<int> GetEmployeesOnSickLeaveCount();
    Task<int> GetMoneyPaidToday();
    Task<int> GetMoneyPaidAllTime();
}