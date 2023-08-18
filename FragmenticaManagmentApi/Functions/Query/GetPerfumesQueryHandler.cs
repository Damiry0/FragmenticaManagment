using FragmenticaManagment.Models.DTOs;
using FragmenticaManagmentCore;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FragmenticaManagment.Functions.Query;

public class GetPerfumesQueryHandler : IRequestHandler<GetPerfumesQuery, List<PerfumeDto>>
{
    private readonly IRepository<Perfume> _perfumeRepository;
    public GetPerfumesQueryHandler(IRepository<Perfume> perfumeRepository)
    {
        _perfumeRepository = perfumeRepository;
    }
    
    public async Task<List<PerfumeDto>> Handle(GetPerfumesQuery request, CancellationToken cancellationToken)
    {
        var perfumes = await _perfumeRepository.GetAllAsNoTracking()
            .Select(x => new PerfumeDto())
            .ToListAsync(cancellationToken: cancellationToken);

        return perfumes;
    }
}