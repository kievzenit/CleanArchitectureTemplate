
using CleanArchitectureTemplate.Application.Abstractions.Services;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTemplate.Application.Weather.Queries;

public sealed record GetCityWeatherQuery(string City) : IQuery<CityWeatherResponse>;

public sealed record CityWeatherResponse(string City, float TemperatureC, float TemperatureF);

internal sealed class GetCityWeatherQueryHandler : IQueryHandler<GetCityWeatherQuery, CityWeatherResponse>
{
    private readonly ILogger<GetCityWeatherQueryHandler> _logger;
    private readonly IWeatherService _weatherService;

    public GetCityWeatherQueryHandler(ILogger<GetCityWeatherQueryHandler> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    public async Task<CityWeatherResponse> Handle(GetCityWeatherQuery query, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Started processing weather query for city: {city}", query.City);

        if (string.IsNullOrWhiteSpace(query.City))
            throw new Exception("City must not be empty or whitespace.");

        var response = await _weatherService.GetWeatherAsync(query.City);

        _logger.LogInformation("Finished processing query.");

        return new(response.City, response.TemperatureC, response.TemperatureF);
    }
}
