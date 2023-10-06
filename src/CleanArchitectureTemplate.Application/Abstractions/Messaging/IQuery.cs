using MediatR;

namespace CleanArchitectureTemplate.Application.Abstractions.Messaging;

public interface IQuery<TResult> : IRequest<TResult> where TResult : notnull { }
