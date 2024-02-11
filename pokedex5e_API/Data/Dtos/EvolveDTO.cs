using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class EvolveDTO
{
    [JsonPropertyName("into")]
    public required List<string> Into { get; init; } = new();

    [JsonPropertyName("requires")]
    public List<string> Requires { get; init; } = new();

    [JsonPropertyName("current_stage")]
    public required short CurrentStage { get; init; }

    [JsonPropertyName("total_stages")]
    public required short TotalStages { get; init; }

    [JsonPropertyName("points")]
    public required short Points { get; init; }

    [JsonPropertyName("level")]
    public short? Level { get; init; }

    [JsonPropertyName("move")]
    public string? Move { get; init; }
}
