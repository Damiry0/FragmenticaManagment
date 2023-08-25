using FragmenticaManagment.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FragmenticaManagment.Controllers;

public class PerfumeController(ISender mediator) : Controller
{
    [HttpGet("perfume/{guid:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPerfume(Guid guid)
    {
        await mediator.Send(new GetPerfumeQuery(guid));
        return Ok();
    }
    
    [HttpGet("perfumes")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPerfumes()
    {
        await mediator.Send(new GetPerfumesQuery());
        return Ok();
    }
}
