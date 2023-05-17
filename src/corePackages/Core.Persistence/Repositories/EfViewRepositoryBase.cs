using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Core.Persistence.Repositories;

public class EfViewRepositoryBase<TEntity, TContext> : IAsyncViewRepository<TEntity>
    where TEntity : SqlView
    where TContext : DbContext
{
    
    protected readonly TContext Context;

    public EfViewRepositoryBase(TContext context)
    {
        Context = context;
    }
    
    
    
    public IQueryable<TEntity> Query() => Context.Set<TEntity>();


    public async Task<TEntity?> GetFirstViewAsync(bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Query();
        if (!enableTracking)
            queryable = queryable.AsNoTracking();
        return await queryable.FirstAsync(cancellationToken: cancellationToken);
    }
}