using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("PDKSConnectionString"))
        );

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<ILoginAndExitRepository, LoginAndExitRepository>();
        services.AddScoped<IDailyReportRepository, DailyReportRepository>();
        
        
        services.AddScoped<IDashboardRepository,DashboardRepository>();
    //services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}
