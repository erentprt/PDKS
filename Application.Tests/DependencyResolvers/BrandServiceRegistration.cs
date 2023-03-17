using Application.Features.Departments.Commands.Create;
using Application.Features.Departments.Commands.Delete;
using Application.Features.Departments.Commands.Update;
using Application.Tests.Mocks.FakeData;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Tests.DependencyResolvers;

public static class DepartmentServiceRegistration
{
    public static void AddDepartmentServices(this IServiceCollection services)
    {
        services.AddTransient<DepartmentFakeData>();
        services.AddTransient<CreateDepartmentCommand>();
        services.AddTransient<UpdateDepartmentCommand>();
        services.AddTransient<DeleteDepartmentCommand>();
        services.AddSingleton<CreateDepartmentCommandValidator>();
        services.AddSingleton<UpdateDepartmentCommandValidator>();
    }
}
