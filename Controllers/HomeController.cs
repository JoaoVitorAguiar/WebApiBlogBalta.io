using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public ActionResult Get() => Ok(); //Health Check

        [HttpGet("v1/env")]
        public IActionResult GetEnv(
            [FromServices] IConfiguration configuration
            )
        {
            var env = configuration.GetValue<string>("Env");
            return Ok( new
                {
                    environment = env
                });
        }
    }
}
