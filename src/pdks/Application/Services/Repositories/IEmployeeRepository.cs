using Core.Persistence.Repositories;
using Domain.Enums;

namespace Application.Services.Repositories;

public interface IEmployeeRepository:IAsyncRepository<Employee>,IRepository<Employee>
{
    
}