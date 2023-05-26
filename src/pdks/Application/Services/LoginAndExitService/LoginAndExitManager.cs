using Application.Services.Repositories;
using Domain.Entities;

namespace Application.Services.LoginAndExitService;

public class LoginAndExitManager:ILoginAndExitService
{
    private readonly ILoginAndExitRepository  _loginAndExitRepository;
    private readonly IEmployeeRepository _employeeRepository;
    public LoginAndExitManager(ILoginAndExitRepository loginAndExitRepository, IEmployeeRepository employeeRepository)
    {
        _loginAndExitRepository = loginAndExitRepository;
        _employeeRepository = employeeRepository;
    }

    public async Task<List<LoginAndExit>> GetByDate(DateTime date)
    {
        var datex = date.ToString("yyyy-MM-dd");
        var loginAndExitList =  await _loginAndExitRepository.GetListAsync(x => x.CreatedDate.Date == date.Date);
        List<LoginAndExit> loginAndExits = new();
        foreach (var loginAndExit in loginAndExitList.Items)
        {
            if (loginAndExit.CreatedDate.Date.ToString("yyyy-MM-dd") == datex)
            {
                loginAndExits.Add(loginAndExit);
            }
        }
        return loginAndExits;
    }
    
    public async Task<List<LoginAndExit>> GetByEmployeeId(int employeeId)
    {
        var employee = await _employeeRepository.GetAsync(x => x.Id == employeeId);
        var loginAndExitList =  await _loginAndExitRepository.GetListAsync(x => x.EmployeeCode == employee.EmployeeCode);
        var loginAndExits = loginAndExitList.Items;
        return (List<LoginAndExit>)loginAndExits;
    }
}