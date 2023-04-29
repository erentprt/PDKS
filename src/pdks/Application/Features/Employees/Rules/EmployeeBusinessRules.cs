using Application.Features.Employees.Commands.Create;
using Application.Features.Employees.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcers.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Employees.Rules;

public class EmployeeBusinessRules:BaseBusinessRules
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeBusinessRules(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task EmployeeCodeIdentityNumberPhoneNumberMustBeUnique(CreateEmployeeCommand employee)
    {
        var result = await _employeeRepository.GetAsync(x=>x.EmployeeCode == employee.EmployeeCode || x.IdentityNumber == employee.IdentityNumber || x.PhoneNumber == employee.PhoneNumber);
        if (result is not null)
            throw new BusinessException(EmployeesMessages.EmployeeCodeIdentityNumberPhoneNumberMustBeUnique);

    }

    public async Task EmployeeIdShouldExistWhenSelected(int requestId)
    {
        var result = await _employeeRepository.GetAsync(x => x.Id == requestId, enableTracking: false);
        if (result is null)
            throw new BusinessException(EmployeesMessages.DepartmentIdShouldExistWhenSelected);
    }
    
    public void EmployeeIdShouldExistWhenSelected(Employee? employee)
    {
        if (employee is null)
            throw new BusinessException(EmployeesMessages.EmployeeNotExists);
    }
    
    public async Task EmployeeIdentityEmployeeCodeOrPhoneNumberCanNotBeDuplicatedWhenUpdated(Employee employee)
    {
        Employee? result = await _employeeRepository.GetAsync(x => x.EmployeeCode.ToLower() != employee.EmployeeCode.ToLower() && x.IdentityNumber != employee.IdentityNumber && x.PhoneNumber != employee.PhoneNumber);
        if (result != null)
            throw new BusinessException(EmployeesMessages.EmployeeCodeIdentityNumberPhoneNumberMustBeUnique);
    }
}