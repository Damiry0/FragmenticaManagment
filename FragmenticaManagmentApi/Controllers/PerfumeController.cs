using FragmenticaManagment.Functions.Command;
using FragmenticaManagment.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FragmenticaManagment.Controllers;

public class PerfumeController(ISender mediator) : Controller
{
    [HttpGet("perfume/{guid:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPerfume(Ulid ulid)
    {
        await mediator.Send(new GetPerfumeQuery(ulid));
        return Ok();
    }
    
    [HttpGet("perfumes")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPerfumes()
    {
        await mediator.Send(new GetPerfumesQuery());
        return Ok();
    }
    
    [HttpGet("perfumes")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreatePerfume()
    {
        await mediator.Send(new CreatePerfumeCommand());
        return Created("", null);
    }
    
    [HttpGet("perfumes")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdatePerfume()
    {
        await mediator.Send(new UpdatePerfumeCommand());
        return NoContent();
    }
    
    [HttpGet("perfumes")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> DeletePerfume()
    {
        await mediator.Send(new DeletePerfumeCommand());
        return NoContent();
    }
}
