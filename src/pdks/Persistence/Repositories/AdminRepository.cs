using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class AdminRepository:EfRepositoryBase<Admin,BaseDbContext>,IAdminRepository
{
    public AdminRepository(BaseDbContext context) : base(context)
    {
    }
}