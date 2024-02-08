using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;


 public class MoveDTO
    {
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        [JsonPropertyName("Description")]
        public required string Description { get; init; }

        [JsonPropertyName("Duration")]
        public required string Duration { get; init; }

        [JsonPropertyName("Move Power")]
        public List<string> Power { get; init; } = new();

        [JsonPropertyName("Move Time")]
        public required string Time { get; init; }

        [JsonPropertyName("PP")]
        public required short PowerPoints { get; init; }

        [JsonPropertyName("Range")]
        public required string Range { get; init; }

        [JsonPropertyName("Scaling")]
        public string Scaling { get; init; } = string.Empty;

        [JsonPropertyName("Type")]
        public required string Type { get; init; }

    [JsonPropertyName("Save")]
    public string Save { get; init; } = string.Empty;

    [JsonPropertyName("tm")]
    public short TechnicalMachine { get; init; } = 0;

        [JsonPropertyName("atk")]
        public bool IsAttack { get; init; }

        [JsonPropertyName("Damage")]
        public Dictionary<short, DamageDto> Damage { get; init; } = new();
    }

    public class DamageDto
    {
        [JsonPropertyName("amount")]
        public required short DiceAmount { get; init; }

        [JsonPropertyName("dice_max")]
        public required short DiceMax { get; init; }

        [JsonPropertyName("move")]
        public required bool AddMoveModifier { get; init; }
    }


