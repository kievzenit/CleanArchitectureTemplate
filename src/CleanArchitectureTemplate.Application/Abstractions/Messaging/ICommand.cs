using MediatR;

namespace CleanArchitectureTemplate.Application.Abstractions.Messaging;

public interface ICommand : IRequest { }

public interface ICommand<TResult> : IRequest<TResult> where TResult : notnull { }
