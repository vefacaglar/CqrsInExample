using CqrsInExample.Application.Utils;
using CqrsInExample.Domain.Games;
using CqrsInExample.Domain.Games.Request;
using Microsoft.AspNetCore.Mvc;

namespace CqrsInExample.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly Messages _messages;

        public GamesController(
            Messages messages
            )
        {
            _messages = messages;
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
            _messages.Dispatch(command);
            return Ok();
        }
    }
}

