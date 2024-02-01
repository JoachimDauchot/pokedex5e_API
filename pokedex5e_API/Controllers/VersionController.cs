using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pokedex5e_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet] public async Task<string> Get()
        {
            return "1.0.0";
        }
    }
}
