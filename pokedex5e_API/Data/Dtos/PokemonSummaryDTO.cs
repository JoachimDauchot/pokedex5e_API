using System.Text.Json.Serialization;

namespace pokedex5e_API.Data.Dtos;

public class PokemonSummaryDTO
{
    public int Index {  get; private set; }
    public string Name {  get; private set; }
    public float SpeciesRating { get; private set; }
    public IEnumerable<string> Types { get; private set;}

    public PokemonSummaryDTO(int index, string name, float speciesRating, IEnumerable<string> types) {
        this.Index = index;
        this.Name = name;
        this.SpeciesRating = speciesRating;
        this.Types = types;
    }


}
