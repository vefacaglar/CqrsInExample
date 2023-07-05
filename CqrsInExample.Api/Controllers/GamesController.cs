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
        private readonly ISender _sender;

        public GamesController(
            ISender sender
            )
        {
            _sender = sender;
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

            var result = await _sender.Send(command);

            return Ok(result);
        }
    }
}

