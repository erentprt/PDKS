using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.SqlViews;
using Persistence.Context;

namespace Persistence.Repositories;

public class DashboardRepository:EfViewRepositoryBase<DashboardStatistic,BaseDbContext>,IDashboardRepository
{
    public DashboardRepository(BaseDbContext context) : base(context)
    {
    }
}