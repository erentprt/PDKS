using System.Reflection;
using Core.Persistence.Repositories;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context;

public class BaseDbContext:DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

    
    
    
    
    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration)
        : base(dbContextOptions)
    {
        Configuration = configuration;
    }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        IEnumerable<EntityEntry<Entity>> entries = ChangeTracker
            .Entries<Entity>()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

        foreach (EntityEntry<Entity> entry in entries)
            _ = entry.State switch
            {
                EntityState.Added => entry.Entity.CreatedDate = DateTime.UtcNow,
                EntityState.Modified => entry.Entity.UpdatedDate = DateTime.UtcNow
            };
        return await base.SaveChangesAsync(cancellationToken);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
}