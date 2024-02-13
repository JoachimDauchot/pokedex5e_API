using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class EvolveDTO
{
    [JsonPropertyName("into")]
    public required List<string> Into { get; set; } = new();

    [JsonPropertyName("from")]
    public  List<string> From { get; set; } = new();

    [JsonPropertyName("requires")]
    public List<string> Requires { get; set; } = new();

    [JsonPropertyName("current_stage")]
    public required short CurrentStage { get; set; }

    [JsonPropertyName("total_stages")]
    public required short TotalStages { get; set; }

    [JsonPropertyName("points")]
    public required short Points { get; set; }

    [JsonPropertyName("level")]
    public short? Level { get; set; }

    [JsonPropertyName("move")]
    public string? Move { get; set; }
}
