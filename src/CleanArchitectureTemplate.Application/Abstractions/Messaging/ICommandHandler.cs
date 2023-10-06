using MediatR;

namespace CleanArchitectureTemplate.Application.Abstractions.Messaging;

public interface ICommandHandler<TCommand>
    : IRequestHandler<TCommand>
    where TCommand : ICommand
{ }

public interface ICommandHandler<TCommand, TResult>
    : IRequestHandler<TCommand, TResult>
    where TCommand : ICommand<TResult>
    where TResult : notnull
{ }
