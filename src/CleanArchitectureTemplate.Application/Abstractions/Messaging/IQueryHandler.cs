using MediatR;

namespace CleanArchitectureTemplate.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResult>
    : IRequestHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
    where TResult : notnull
{ }
