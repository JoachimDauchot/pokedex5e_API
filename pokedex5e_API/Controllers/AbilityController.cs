using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pokedex5e_API.Data.Dtos;
using pokedex5e_API.Resources;
using System.Runtime.Serialization;
using System.Text.Json;

namespace pokedex5e_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbilityController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<AbilityDTO>> GetAbilitiesAsync(CancellationToken cancellation)
        {
            var abilitiesFromJSON = new AbilityFromJSON();

            var pathToAbilities = ResourcePath.ForFile("Data/abilities.json");
            await using var abilitiesJetStream = new FileStream(pathToAbilities, FileMode.Open, FileAccess.Read);
            abilitiesFromJSON.Ability = await JsonSerializer.DeserializeAsync<Dictionary<string, AbilityDescription>>(abilitiesJetStream, JsonSerializerOptions.Default, cancellation);



            

            if (abilitiesFromJSON is null)
                throw new SerializationException("Ability could not be deserialized");


            var abilities = abilitiesFromJSON.ToDto();

            return abilities;

        }
   
    }
}
