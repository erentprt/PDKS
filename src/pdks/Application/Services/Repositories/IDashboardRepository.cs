using Core.Persistence.Repositories;
using Domain.SqlViews;

namespace Application.Services.Repositories;

public interface IDashboardRepository:IAsyncViewRepository<DashboardStatistic>
{
    
}