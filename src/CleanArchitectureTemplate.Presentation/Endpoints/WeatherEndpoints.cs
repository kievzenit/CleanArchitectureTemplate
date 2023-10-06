using CleanArchitectureTemplate.Application.Weather.Queries;
using Microsoft.AspNetCore.Http;

namespace CleanArchitectureTemplate.Presentation.Endpoints;

internal sealed class WeatherEndpoints
{
    public static async Task<IResult> GetWeatherHandler(string city, IMessageSender sender, CancellationToken cancellationToken)
    {
        var query = new GetCityWeatherQuery(city);
        var result = await sender.SendAsync(query, cancellationToken);

        return Results.Ok(result);
    }
}
