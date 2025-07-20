using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Week5_HandsOn3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        [HttpGet("dashboard")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetDashboard()
        {
            var username = User.Identity?.Name;
            return Ok($"Welcome to the Admin Dashboard, {username}!");
        }
    }
}
