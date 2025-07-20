using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Week5_HandsOn2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("data")]
        [Authorize]
        public IActionResult GetProtectedData()
        {
            var username = User.Identity?.Name;
            return Ok($"This is protected data for user: {username}");
        }
    }
}
