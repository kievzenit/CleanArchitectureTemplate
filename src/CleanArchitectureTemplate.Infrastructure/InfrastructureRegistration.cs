using CleanArchitectureTemplate.Application.Abstractions.Services;
using CleanArchitectureTemplate.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureTemplate.Infrastructure;

public static class InfrastructureRegistration
{
    public static IServiceCollection RegisterInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService, WeatherService>();

        return services;
    }
}
