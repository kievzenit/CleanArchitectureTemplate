namespace CleanArchitectureTemplate.Application.Abstractions.Messaging;

public interface IMessageSender
{
    Task SendAsync(ICommand command, CancellationToken cancellationToken);

    Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> command, CancellationToken cancellationToken)
        where TResponse : notnull;

    Task<TResponse> SendAsync<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken)
        where TResponse : notnull;
}
