using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class AbilityDTO
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class AbilityDescription
{
    [JsonPropertyName("Description")]
    public required string Description { get; set; }
}

public class AbilityFromJSON
{
    public Dictionary<string, AbilityDescription>? Ability { get; set; }

    
}

public static class AbilityExtensionMethod
{
    public static List<AbilityDTO> ToDto(this AbilityFromJSON abilityFromJSON)
    {
        

        var abilities = abilityFromJSON.Ability.Select(x => new AbilityDTO
        {
            Name = x.Key,
            Description = x.Value.Description,
        }).ToList();


        return abilities;
    }
}



