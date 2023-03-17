using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class DepartmentRepository:EfRepositoryBase<Department,BaseDbContext>
{
    public DepartmentRepository(BaseDbContext context) : base(context)
    {
    }
}