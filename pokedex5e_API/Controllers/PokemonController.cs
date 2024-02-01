using Microsoft.AspNetCore.Mvc;
using pokedex5e_API.Data.Dtos;
using pokedex5e_API.Resources;
using System.Runtime.Serialization;
using System.Text.Json;


namespace pokedex5e_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
 
    [HttpGet("summaries")]
    public async Task<IEnumerable<PokemonSummaryDTO>> getSummariesAsync(CancellationToken cancellation)
    {
        var pathToSummaries = ResourcePath.ForFile("Data/PokemonSummaries.json");
        await using var pokemonSummaryJsonStream = new FileStream(pathToSummaries, FileMode.Open, FileAccess.Read);
        var pokemonSummaries = await JsonSerializer.DeserializeAsync<List<PokemonSummaryDTO>>(pokemonSummaryJsonStream, JsonSerializerOptions.Default, cancellation);

        if(pokemonSummaries is null)
            throw new SerializationException("Pokemon could not be deserialized");
        

        return pokemonSummaries
            .Where(x => x.Index < 10000)
            .OrderBy(x => x.Index);
    }
}
