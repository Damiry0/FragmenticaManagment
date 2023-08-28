using FragmenticaManagment.Abstractions;
using FragmenticaManagment.Models.DTOs;
using FragmenticaManagmentCore.Domain;
using FragmenticaManagmentCore.Domain.Primitives;
using FragmenticaManagmentCore.Repository;
using Microsoft.EntityFrameworkCore;

namespace FragmenticaManagment.Functions.Query;

public class GetPerfumeQueryHandler(IRepository<Perfume> perfumeRepository) : IQueryHandler<GetPerfumeQuery, PerfumeDto>
{
    public async Task<Result<PerfumeDto>> Handle(GetPerfumeQuery request, CancellationToken cancellationToken)
    {
        var perfume = await perfumeRepository.GetAllAsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == request.guid, cancellationToken: cancellationToken);

        var perfumeDto = new PerfumeDto();

        return perfumeDto;
    }
}