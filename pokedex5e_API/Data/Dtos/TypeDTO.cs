namespace pokedex5e_API.Data.Dtos;

public class TypeDTO
{
    public string Name { get;private set; }

    public TypeDTO(string name) {
        this.Name = name;
    }
}
