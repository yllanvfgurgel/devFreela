using DevFreela.API.Models;
using DevFreela.API.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly OpeningTimeOptions _options;
        public UsersController(IOptions<OpeningTimeOptions> options)
        {
            _options = options.Value;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel model)
        {
            return CreatedAtAction(nameof(GetById), new {id = 1}, model);
        }
    }
}
