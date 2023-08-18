using FragmenticaManagment.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FragmenticaManagment.Controllers;


public class PerfumeController : Controller
{
    private readonly IMediator _mediator;
    public PerfumeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> GetPerfume(Guid guid)
    {
        await _mediator.Send(new GetPerfumeQuery(guid));
        return NoContent();
    }
    
}
