using Microsoft.AspNetCore.Mvc;

namespace Week5_HandsOn4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("Service is alive!");
        }
    }
}
