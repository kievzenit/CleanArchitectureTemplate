using CleanArchitectureTemplate.Application.Abstractions.Services;

namespace CleanArchitectureTemplate.Infrastructure.Services;

internal sealed class WeatherService : IWeatherService
{
    public Task<WeatherResponse> GetWeatherAsync(string city)
    {
        var currentTemperatureC = Random.Shared.NextSingle() * 10.231f;
        var currentTemperatureF = currentTemperatureC * (9 / 5) + 32;

        var response = new WeatherResponse(city, currentTemperatureC, currentTemperatureF);
        return Task.FromResult(response);
    }
}
