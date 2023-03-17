using Application.Features.Departments.Profiles;
using Application.Features.Departments.Rules;
using Application.Services.Repositories;
using Application.Tests.Mocks.FakeData;
using Core.Test.Application.Repositories;
using Domain.Entities;

namespace Application.Tests.Mocks.Repositories;

public class DepartmentMockRepository : BaseMockRepository<IDepartmentRepository, Department, MappingProfiles, DepartmentBusinessRules, DepartmentFakeData>
{
    public DepartmentMockRepository(DepartmentFakeData fakeData)
        : base(fakeData) { }
}
