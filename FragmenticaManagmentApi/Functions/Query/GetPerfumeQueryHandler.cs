using FragmenticaManagment.Models.DTOs;
using FragmenticaManagmentCore.Domain;
using FragmenticaManagmentCore.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FragmenticaManagment.Functions.Query;

public class GetPerfumeQueryHandler : IRequestHandler<GetPerfumeQuery, PerfumeDto>
{
    private readonly IRepository<Perfume> _perfumeRepository;
    
    public GetPerfumeQueryHandler(IRepository<Perfume> perfumeRepository)
    {
        _perfumeRepository = perfumeRepository;
    }
    public async Task<PerfumeDto> Handle(GetPerfumeQuery request, CancellationToken cancellationToken)
    {
        var perfume = await _perfumeRepository.GetAllAsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == request.guid, cancellationToken: cancellationToken);

        var perfumeDto = new PerfumeDto();

        return perfumeDto;
    }
    
    
}