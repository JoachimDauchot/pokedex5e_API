using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class MovesDTO
{
    [JsonPropertyName("Level")]
    public IDictionary<short, List<string>> LevelMoves { get; init; }
= new Dictionary<short, List<string>>();

    [JsonPropertyName("Starting Moves")]
    public IEnumerable<string> StartingMoves { get; init; }
        = new List<string>();

    [JsonPropertyName("TM")]
    public IEnumerable<short> TechnicalMachines { get; init; }
        = new List<short>();

    [JsonPropertyName("egg")]
    public IEnumerable<string> EggMoves { get; init; }
        = new List<string>();
}
