using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pokedex5e_API.Data.Dtos;
using pokedex5e_API.Resources;
using System.Runtime.Serialization;
using System.Text.Json;

namespace pokedex5e_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovesController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<MoveDTO>> GetMovesAsync(CancellationToken cancellation)
    {
        var pathToMoves = ResourcePath.ForFile("Data/Moves.json");
        await using var movesJetStream = new FileStream(pathToMoves, FileMode.Open, FileAccess.Read);
        var moves = await JsonSerializer.DeserializeAsync<List<MoveDTO>>(movesJetStream, JsonSerializerOptions.Default, cancellation);
   

        if (moves is null)
            throw new SerializationException("Move could not be deserialized");


        return moves;
    }
}
