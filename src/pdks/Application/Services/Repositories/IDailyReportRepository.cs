using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IDailyReportRepository:IAsyncRepository<DailyReport>,IRepository<DailyReport>
{
    
}