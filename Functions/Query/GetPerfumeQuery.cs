using MediatR;

namespace FragmenticaManagment.Functions.Query;

public record GetPerfumeQuery(Guid guid) : IRequest<Unit>;