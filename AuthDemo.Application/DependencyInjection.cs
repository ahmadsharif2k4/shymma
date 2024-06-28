using AuthDemo.Application.Abstractions.Application;
using AuthDemo.Application.Services;
using AuthDemo.Domain.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthDemo.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserResolverService, UserResolverService>();

        services.Configure<DatabaseConfiguration>(configuration.GetSection("DatabaseConfiguration"));
        services.Configure<AuthenticationConfiguration>(configuration.GetSection("AuthenticationConfiguration"));
        services.Configure<HashingConfiguration>(configuration.GetSection("HashingConfiguration"));
        return services;
    }
}