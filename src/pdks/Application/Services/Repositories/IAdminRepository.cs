using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IAdminRepository:IAsyncRepository<Admin>
{
    
}