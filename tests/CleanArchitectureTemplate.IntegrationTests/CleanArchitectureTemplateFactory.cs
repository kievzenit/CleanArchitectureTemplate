using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Testcontainers.PostgreSql;

namespace CleanArchitectureTemplate.IntegrationTests;

public sealed class CleanArchitectureTemplateFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgresqlContainer =
        new PostgreSqlBuilder()
            .WithImage("postgres:15.3")
            .WithPortBinding(5432, true)
            .WithDatabase("db")
            .WithUsername("user")
            .WithPassword("password")
            .WithCleanUp(true)
            .WithAutoRemove(true)
            .Build();

    public HttpClient HttpClient { get; private set; } = default!;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(configuration => { });
    }

    public Task InitializeAsync()
    {
        HttpClient = CreateClient();
        return Task.CompletedTask;
    }

    Task IAsyncLifetime.DisposeAsync() => Task.CompletedTask;
}
