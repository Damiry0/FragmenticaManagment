using FragmenticaManagmentCore.Domain.Primitives;
using MediatR;

namespace FragmenticaManagment.Abstractions;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;