using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class LoginAndExitRepository:EfRepositoryBase<LoginAndExit,BaseDbContext>,ILoginAndExitRepository
{
    public LoginAndExitRepository(BaseDbContext context) : base(context)
    {
    }
}