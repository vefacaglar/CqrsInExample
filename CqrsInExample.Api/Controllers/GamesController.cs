using CqrsInExample.Application.Utils;
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
    }
}
