using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Version = pokedex5e_API.Resources.Data.Version;

namespace pokedex5e_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet] public async Task<string> Get()
        {
            return Version.Number;
        }
    }
}
