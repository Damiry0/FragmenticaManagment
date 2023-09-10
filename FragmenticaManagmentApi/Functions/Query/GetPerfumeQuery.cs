using FragmenticaManagment.Abstractions;
using FragmenticaManagment.Models.DTOs;

namespace FragmenticaManagment.Functions.Query;

public record GetPerfumeQuery(Ulid ulid) : IQuery<PerfumeDto>;