using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class PokemonDTO
{
    
[JsonPropertyName("index")]
    public required short Index { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("size")]
    public required string Size { get; init; }

    [JsonPropertyName("SR")]
    public required double SpeciesRating { get; init; }

    [JsonPropertyName("MIN LVL FD")]
    public short MinimumLevelFound { get; init; }

    [JsonPropertyName("Type")]
    public List<string> Types { get; init; } = new();

    [JsonPropertyName("Abilities")]
    public List<string> Abilities { get; init; } = new();

    [JsonPropertyName("Hidden Ability")]
    public string? HiddenAbility { get; init; }

    [JsonPropertyName("WSp")]
    public short WalkingSpeed { get; init; }

    [JsonPropertyName("Fsp")]
    public short FlyingSpeed { get; init; }

    [JsonPropertyName("Ssp")]
    public short SwimmingSpeed { get; init; }

    [JsonPropertyName("Climbing Speed")]
    public short ClimbingSpeed { get; init; }

    [JsonPropertyName("Burrowing Speed")]
    public short BurrowingSpeed { get; init; }

    [JsonPropertyName("AC")]
    public short ArmorClass { get; init; }

    [JsonPropertyName("HP")]
    public short HitPoints { get; init; }

    [JsonPropertyName("Hit Dice")]
    public short HitDice { get; init; }

    [JsonPropertyName("attributes")]
    public AttributesDTO Attributes { get; init; } = new();

    [JsonPropertyName("Moves")]
    public MovesDTO Moves { get; init; } = new();

    [JsonPropertyName("saving_throws")]
    public List<string> SavingThrows { get; init; } = new();

    [JsonPropertyName("Skill")]
    public List<string> Skills { get; init; } = new();

    [JsonPropertyName("Evolve")]
    public EvolveDTO? Evolve { get; init; }
}
