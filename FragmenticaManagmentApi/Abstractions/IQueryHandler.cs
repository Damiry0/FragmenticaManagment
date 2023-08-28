using FragmenticaManagmentCore.Domain.Primitives;
using MediatR;

namespace FragmenticaManagment.Abstractions;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>;