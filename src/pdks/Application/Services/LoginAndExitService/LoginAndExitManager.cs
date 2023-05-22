using Application.Services.Repositories;
using Domain.Entities;

namespace Application.Services.LoginAndExitService;

public class LoginAndExitManager:ILoginAndExitService
{
    private readonly ILoginAndExitRepository  _loginAndExitRepository;

    public LoginAndExitManager(ILoginAndExitRepository loginAndExitRepository)
    {
        _loginAndExitRepository = loginAndExitRepository;
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
}