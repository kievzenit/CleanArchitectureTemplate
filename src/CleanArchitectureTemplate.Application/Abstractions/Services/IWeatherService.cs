namespace CleanArchitectureTemplate.Application.Abstractions.Services;

public sealed record WeatherResponse(string City, float TemperatureC, float TemperatureF);

public interface IWeatherService
{
    Task<WeatherResponse> GetWeatherAsync(string city);
}
