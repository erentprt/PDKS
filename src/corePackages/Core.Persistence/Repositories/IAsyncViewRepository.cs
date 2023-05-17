using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Core.Persistence.Repositories;

public interface IAsyncViewRepository<T>:IQuery<T> where T:SqlView
{
    Task<T?> GetFirstViewAsync(bool enableTracking = true,
        CancellationToken cancellationToken = default);
}