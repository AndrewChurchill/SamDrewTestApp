using Microsoft.AspNetCore.Mvc;

namespace SamDrewTestApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await Task.FromResult("HELLO, NEW YORK!!!"));
        }
    }
}
