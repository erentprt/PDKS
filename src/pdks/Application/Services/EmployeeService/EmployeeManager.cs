using Application.Services.Repositories;
using Domain.Entities;

namespace Application.Services.EmployeeService;

public class EmployeeManager : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeManager(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<Employee> GetById(int id)
    {
        Employee? employee =await _employeeRepository.GetAsync(e=>e.Id==id);
        return employee;
    }
    
    public async Task<Employee> GetByEmployeeCode(string employeeCode)
    {
        Employee? employee =await _employeeRepository.GetAsync(e=>e.EmployeeCode==employeeCode);
        return employee;
    }
    
    public async Task<Employee> SetDailyExit(int id, bool atwork, double dailySalary, int dailyWorkTime)
    {
        Employee? employee =await _employeeRepository.GetAsync(e=>e.Id==id);
        employee!.AtWork = atwork;
        employee!.AllTimeSalary += dailySalary;
        employee!.TotalWorkTime += dailyWorkTime;
        await _employeeRepository.UpdateAsync(employee);
        return employee;
    }
    
    public async Task<Employee> SetAtWork(int id, bool atwork)
    {
        Employee? employee =await _employeeRepository.GetAsync(e=>e.Id==id);
        employee!.AtWork = atwork;
        await _employeeRepository.UpdateAsync(employee);
        return employee;
    }

    public async Task<int> GetAllEmployeeCount()
    {
        var employees = await _employeeRepository.GetListAsync();
        return employees.Count;
        
    }
    
    public async Task UpdateAllEmployeeAtWorkFalse()
    {
        var employees = await _employeeRepository.GetListAsync();
        var employeeList = new List<Employee>();
        foreach (var employee in employees.Items)
        {
            employee.AtWork = false;
            employeeList.Add(employee);
        }
        await _employeeRepository.UpdateRangeAsync(employeeList);
    }
}