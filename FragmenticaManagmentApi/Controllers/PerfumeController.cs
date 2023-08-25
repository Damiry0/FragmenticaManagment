using FragmenticaManagment.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FragmenticaManagment.Controllers;

public class PerfumeController(ISender mediator) : Controller
{
    [HttpGet("perfume/{guid:guid}")]
    public async Task<IActionResult> GetPerfume(Guid guid)
    {
        await mediator.Send(new GetPerfumeQuery(guid));
        return NoContent();
    }
    
    [HttpGet("perfumes")]
    public async Task<IActionResult> GetPerfumes()
    {
        await mediator.Send(new GetPerfumesQuery());
        return NoContent();
    }
}
