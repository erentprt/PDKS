using Application.Features.Departments.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcers.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Departments.Rules;

public class DepartmentBusinessRules:BaseBusinessRules
{
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentBusinessRules(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }
    
    public async Task DepartmentIdShouldExistWhenSelected(int id)
    {
        Department? result = await _departmentRepository.GetAsync(predicate: b => b.Id == id, enableTracking: false);
        if (result == null)
            throw new BusinessException(DepartmentsMessages.DepartmentNotExists);
    }
    
    public void DepartmentIdShouldExistWhenSelected(Department? brand)
    {
        if (brand == null)
            throw new BusinessException(DepartmentsMessages.DepartmentNotExists);
    }
    
    
    public async Task DepartmentNameCanNotBeDuplicatedWhenInserted(string name)
    {
        Department? result = await _departmentRepository.GetAsync(x => x.Name.ToLower() == name.ToLower());
        if (result != null)
            throw new BusinessException(DepartmentsMessages.DepartmentNameExists);
    }

    public async Task DepartmentNameCanNotBeDuplicatedWhenUpdated(Department brand)
    {
        Department? result = await _departmentRepository.GetAsync(x => x.Id != brand.Id && x.Name.ToLower() == brand.Name.ToLower());
        if (result != null)
            throw new BusinessException(DepartmentsMessages.DepartmentNameExists);
    }
}