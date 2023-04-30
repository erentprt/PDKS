using Domain.Entities;

namespace Application.Services.EmployeeService;

public interface IEmployeeService
{
    public Task<Employee> GetById(int id);
    public Task<Employee> GetByEmployeeCode(string employeeCode);
    public Task<Employee> SetDailyExit(int id, bool atwork, double dailySalary, int dailyWorkTime);
    public Task<Employee> SetAtWork(int id, bool atwork);

}