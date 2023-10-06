using System.Net;
using FluentAssertions;

namespace CleanArchitectureTemplate.IntegrationTests.Endpoints.Weather;

[Collection("Db collection")]
public sealed class GetWeatherHandlerTests
{
    private string TestUrl(string city) => $"v1/weather/{city}";

    private readonly HttpClient _client;

    public GetWeatherHandlerTests(CleanArchitectureTemplateFactory factory)
    {
        _client = factory.HttpClient;
    }

    [Theory]
    [InlineData("London")]
    [InlineData("Kyiv")]
    [InlineData("Berlin")]
    public async Task Handler_ShouldReturn200Status_WhenInputDataIsValid(string city)
    {
        // Arrange
        var httpRequest = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(_client.BaseAddress!, TestUrl(city))
        };

        // Act
        var response = await _client.SendAsync(httpRequest);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        (await response.Content.ReadAsStringAsync()).Should().NotBeEmpty();
    }
}
