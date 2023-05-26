using Domain.Entities;

namespace Application.Services.LoginAndExitService;

public interface ILoginAndExitService
{
    public Task<List<LoginAndExit>> GetByDate(DateTime date);
    public Task<List<LoginAndExit>> GetByEmployeeId(int employeeId);
}