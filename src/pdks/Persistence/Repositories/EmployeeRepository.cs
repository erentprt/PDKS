using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class EmployeeRepository:EfRepositoryBase<Employee,BaseDbContext>,IEmployeeRepository
{
    public EmployeeRepository(BaseDbContext context) : base(context)
    {
    }
}