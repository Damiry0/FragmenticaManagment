using FragmenticaManagment.Models.DTOs;
using MediatR;

namespace FragmenticaManagment.Functions.Query;

public record GetPerfumesQuery : IRequest<List<PerfumeDto>>;