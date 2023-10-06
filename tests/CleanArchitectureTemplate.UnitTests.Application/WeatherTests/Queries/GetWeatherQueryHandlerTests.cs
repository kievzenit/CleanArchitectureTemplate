using CleanArchitectureTemplate.Application.Abstractions.Services;
using CleanArchitectureTemplate.Application.Weather.Queries;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTemplate.UnitTests.Application.WeatherTests.Queries;

public sealed class GetWeatherQueryHandlerTests
{
    private readonly ILogger<GetCityWeatherQueryHandler> loggerMock;
    private readonly IWeatherService weatherServiceMock;

    public GetWeatherQueryHandlerTests()
    {
        loggerMock = Substitute.For<ILogger<GetCityWeatherQueryHandler>>();
        weatherServiceMock = Substitute.For<IWeatherService>();
    }

    [Theory]
    [InlineData("London")]
    [InlineData("Kyiv")]
    [InlineData("Berlin")]
    public async void Handler_ShouldReturnValidData(string city)
    {
        // Arrange
        const float temperatureC = 0;
        const float temperatureF = 32;
        var weatherResponse = new WeatherResponse(city, temperatureC, temperatureF);

        weatherServiceMock.GetWeatherAsync(Arg.Is(city))
            .Returns(weatherResponse);

        var query = new GetCityWeatherQuery(city);
        var queryHandler = new GetCityWeatherQueryHandler(loggerMock, weatherServiceMock);

        // Act
        var response = await queryHandler.Handle(query, default);

        // Assert
        response.City.Should().Be(city);
        response.TemperatureC.Should().Be(temperatureC);
        response.TemperatureF.Should().Be(temperatureF);
    }
}
