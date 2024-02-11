using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class AttributesDTO
{
    [JsonPropertyName("STR")]
    public short Strength { get; init; }

    [JsonPropertyName("DEX")]
    public short Dexterity { get; init; }

    [JsonPropertyName("CON")]
    public short Constitution { get; init; }

    [JsonPropertyName("INT")]
    public short Intelligence { get; init; }

    [JsonPropertyName("WIS")]
    public short Wisdom { get; init; }

    [JsonPropertyName("CHA")]
    public short Charisma { get; init; }
}
