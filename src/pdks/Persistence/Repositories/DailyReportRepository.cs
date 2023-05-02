using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class DailyReportRepository:EfRepositoryBase<DailyReport,BaseDbContext>,IDailyReportRepository
{
    public DailyReportRepository(BaseDbContext context) : base(context)
    {
    }
}