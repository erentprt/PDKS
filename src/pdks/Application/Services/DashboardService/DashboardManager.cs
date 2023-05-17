using Application.Services.Repositories;

namespace Application.Services.DashboardService;

public class DashboardManager:IDashboardService
{
    private readonly IEmployeeRepository _employeeRepository;
    
    public DashboardManager(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    

    public async Task<int> GetAllEmployeeCount()
    {
        var employees = await _employeeRepository.GetListAsync(x=>x.Status==true);
        return employees.Count;
    }

    public async Task<int> GetEmployeesAtWorkCount()
    {
        var employees = await _employeeRepository.GetListAsync(x=>x.Status==true && x.AtWork==true);
        return employees.Count;
    }

    public async Task<int> GetEmployeesNotAtWorkCount()
    {
        var employees = await _employeeRepository.GetListAsync(x=>x.Status==true && x.AtWork==false);
        return employees.Count;
    }

    public Task<int> GetEmployeesWithWorkPermitCount()
    {
        return Task.FromResult(0);
    }

    public Task<int> GetEmployeesOnSickLeaveCount()
    {
        return Task.FromResult(0);
    }

    public async Task<int> GetMoneyPaidToday()
    {
        var employees = await _employeeRepository.GetListAsync(x=>x.TotalWorkTime > 0);
        int totalMoneyPaid = 0;
        foreach (var employee in employees.Items)
        {
            if (employee != null)
                totalMoneyPaid += (int)(employee.HourlySalary * employee.TotalWorkTime);
        }
        return totalMoneyPaid;
    }

    public async Task<int> GetMoneyPaidAllTime()
    {
        var employees = await _employeeRepository.GetListAsync(x=>x.TotalWorkTime > 0);
        int totalMoneyPaid = 0;
        foreach (var employee in employees.Items)
        {
            if (employee != null)
                totalMoneyPaid += (int)employee.AllTimeSalary;
        }
        return totalMoneyPaid;
    }
}