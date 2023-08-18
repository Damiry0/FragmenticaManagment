using MediatR;

namespace FragmenticaManagment.Functions.Query;

public class GetPerfumeQueryHandler : IRequestHandler<GetPerfumeQuery, Unit>
{
    public GetPerfumeQueryHandler()
    {
        
    }
    public Task<Unit> Handle(GetPerfumeQuery request, CancellationToken cancellationToken)
    {
        var perfume = await 
        throw new NotImplementedException();
    }
    
    
}