using MediatR;

namespace CleanArchitectureTemplate.Application.Messaging;

public sealed class MessageSender : IMessageSender
{
    private readonly ISender _sender;

    public MessageSender(ISender sender)
    {
        _sender = sender;
    }

    public Task SendAsync(ICommand command, CancellationToken cancellationToken) =>
        _sender.Send(command, cancellationToken);

    public Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> command, CancellationToken cancellationToken)
        where TResponse : notnull =>
        _sender.Send(command, cancellationToken);

    public Task<TResponse> SendAsync<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken)
        where TResponse : notnull =>
        _sender.Send(query, cancellationToken);
}
