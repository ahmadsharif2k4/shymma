using AuthDemo.Application.Abstractions.Persistence;
using AuthDemo.Persistence.Contexts;
using AuthDemo.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthDemo.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AuthDemoDbContext>(options =>
        {
            options.UseInMemoryDatabase("InMemoryDbName"); // You can replace "InMemoryDbName" with your preferred database name.
        });

        services.AddScoped<IAuthRepository, AuthRepository>();

        return services;
    }
}
