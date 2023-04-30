using Application.Features.LoginAndExits.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcers.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.LoginAndExits.Rules;

public class LoginAndExitBusinessRules:BaseBusinessRules
{
    private readonly ILoginAndExitRepository _loginAndExitRepository;
    private readonly IEmployeeRepository _employeeRepository;
    
    public LoginAndExitBusinessRules(ILoginAndExitRepository loginAndExitRepository, IEmployeeRepository employeeRepository)
    {
        _loginAndExitRepository = loginAndExitRepository;
        _employeeRepository = employeeRepository;
    }
    
    public async Task IsEmployeeCodeNoteExist(string employeeCode)
    {
        var employee = await _employeeRepository.GetAsync(l => l.EmployeeCode == employeeCode);
        if (employee is null)
            throw new BusinessException(LoginAndExitMessages.EmployeeCodeNotFound);
    }
    
    public async Task EmployeeIsAlreadyLoginAndExit(LoginAndExit? lae)
    {
        if (lae != null && lae.ExitTime != null)
            throw new BusinessException(LoginAndExitMessages.EmployeeIsAlreadyLogin);
    }
}