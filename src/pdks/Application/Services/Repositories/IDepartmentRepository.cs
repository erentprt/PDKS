using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IDepartmentRepository:IAsyncRepository<Department>,IRepository<Department>
{
    
}