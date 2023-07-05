using CqrsInExample.Domain.Games;
using CqrsInExample.Domain.Games.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsInExample.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GamesController(
            IMediator mediator
            )
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(CreateGameRequest request)
        {
            var command = new CreateGameCommand(request.Name, request.Description);

            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}

