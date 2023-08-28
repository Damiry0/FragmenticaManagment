using FragmenticaManagment.Models.DTOs;
using FragmenticaManagmentCore.Domain;
using FragmenticaManagmentCore.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FragmenticaManagment.Functions.Query;

public class GetPerfumesQueryHandler(IRepository<Perfume> perfumeRepository) : IRequestHandler<GetPerfumesQuery, List<PerfumeDto>>
{
    public async Task<List<PerfumeDto>> Handle(GetPerfumesQuery request, CancellationToken cancellationToken)
    {
        var perfumes = await perfumeRepository.GetAllAsNoTracking()
            .Include(x => x.Accords)
            .Select(x => new PerfumeDto())
            .ToListAsync(cancellationToken: cancellationToken);

        return perfumes;
    }
}