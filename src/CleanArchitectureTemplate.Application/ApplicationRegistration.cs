using CleanArchitectureTemplate.Application.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureTemplate.Application;

public static class ApplicationRegistration
{
    public static IServiceCollection RegisterApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(AssemblyReference.Assembly));

        services.AddTransient<IMessageSender, MessageSender>();
        return services;
    }
}
