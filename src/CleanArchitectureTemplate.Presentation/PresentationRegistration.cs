using CleanArchitectureTemplate.Presentation.Endpoints;
using CleanArchitectureTemplate.Presentation.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureTemplate.Presentation;

public static class PresentationRegistration
{
    public static IServiceCollection RegisterPresentation(this IServiceCollection services)
    {
        return services;
    }

    public static void MapPresentationMiddlewares(this IApplicationBuilder application)
    {
        application.Use(ExceptionsMiddleware.Handler);
    }

    public static void MapPresentationEndpoints(this IEndpointRouteBuilder routeBuilder)
    {
        routeBuilder.MapV1Group()
            .MapWeather();
    }

    private static IEndpointRouteBuilder MapV1Group(this IEndpointRouteBuilder routeBuilder)
    {
        var v1Group = routeBuilder.MapGroup("v1");
        return v1Group;
    }

    private static IEndpointRouteBuilder MapWeather(this IEndpointRouteBuilder routeBuilder)
    {
        var weatherGroup = routeBuilder.MapGroup("weather");
        weatherGroup.MapGet("{city}", WeatherEndpoints.GetWeatherHandler);

        return routeBuilder;
    }
}
