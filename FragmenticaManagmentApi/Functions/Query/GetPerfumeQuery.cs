using FragmenticaManagment.Abstractions;
using FragmenticaManagment.Models.DTOs;

namespace FragmenticaManagment.Functions.Query;

public record GetPerfumeQuery(Guid guid) : IQuery<PerfumeDto>;