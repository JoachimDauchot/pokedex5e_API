using Microsoft.AspNetCore.Mvc;
using pokedex5e_API.Data.Dtos;
using pokedex5e_API.Resources;
using System.Runtime.Serialization;
using System.Text.Json;




namespace pokedex5e_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
 
    [HttpGet("summaries")]
    public async Task<IEnumerable<PokemonSummaryDTO>> GetSummariesAsync(CancellationToken cancellation)
    {
        var pathToSummaries = ResourcePath.ForFile("Data/PokemonSummaries.json");
        await using var pokemonSummaryJsonStream = new FileStream(pathToSummaries, FileMode.Open, FileAccess.Read);
        var pokemonSummaries = await JsonSerializer.DeserializeAsync<List<PokemonSummaryDTO>>(pokemonSummaryJsonStream, JsonSerializerOptions.Default, cancellation);

        if(pokemonSummaries is null)
            throw new SerializationException("Pokemon could not be deserialized");
        

        return pokemonSummaries
            .Where(x => x.Index < 10000)
            .OrderBy(x => x.Index);
    }

    [HttpGet("pokemons")]
    public async Task<List<PokemonDTO>> GetPokemonsAsync(CancellationToken cancellation)
    {
        var pokemonJsonPath = ResourcePath.ForFile("Data/Pokemons.json");
        await using var pokemonJsonStream = new FileStream(pokemonJsonPath, FileMode.Open, FileAccess.Read);
        var pokemonDtos = await JsonSerializer.DeserializeAsync<List<PokemonDTO>>(pokemonJsonStream, JsonSerializerOptions.Default, cancellation);
        Console.WriteLine("deserialized");
        if (pokemonDtos == null)
            throw new SerializationException("Pokemon could not be deserialized");

        var pokemonEvolved = new Dictionary<string, EvolveDTO?>();

        //foreach (var item in pokemonDtos)
        //{
        //    pokemonEvolved.Add(item.Name, item.Evolve);
        //}

        //var found = 1;

        //foreach (var item in pokemonEvolved)
        //{
        //    if (item.Value is null)
        //    {
        //        pokemonEvolved[item.Key] = new EvolveDTO
        //        {
        //            Into = new(),
        //            From = new(),
        //            CurrentStage = 0,
        //            TotalStages = 0,
        //            Points = 0,
        //            Level = 0,
        //            Move = "",

        //        };
        //    }
        //}


        //while (found > 0)
        //{
        //    found = 0;
        //    foreach (var item in pokemonEvolved)
        //    {
        //        foreach (var item2 in pokemonEvolved)
        //        {                    
        //            foreach (var name in item2.Value!.Into)
        //            {
        //                Console.WriteLine(name);
        //                if (item.Key == name && !item.Value!.From.Contains(item2.Key))
        //                {
        //                    item.Value!.From.Add(item2.Key);
        //                    item.Value.CurrentStage = (short)(item2.Value!.CurrentStage + 1);
        //                    item.Value.TotalStages = (short)(item2.Value!.TotalStages);
        //                    found++;
        //                }
        //            }
        //            foreach (var name in item2.Value.From )
        //            {
        //                if (item.Key == name && !item.Value!.Into.Contains(item2.Key))
        //                {
        //                    Console.WriteLine("HIT");
        //                    item.Value!.Into.Add(item2.Key);                            
        //                    found++;
        //                }
        //            }

        //        }
        //    }            


        //}

        //foreach(var item in pokemonEvolved)
        //{
        //    foreach(var item2 in pokemonDtos)
        //    {
        //        if(item.Key == item2.Name)
        //        {
        //            item2.Evolve = item.Value;
        //        }
        //    }
        //}




        //string fileName = "Pokemons.json";
        //await using FileStream createStream = System.IO.File.Create(fileName);
        //await JsonSerializer.SerializeAsync(createStream, pokemonDtos);



        return pokemonDtos;
    }
}

