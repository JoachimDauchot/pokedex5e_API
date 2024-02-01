namespace pokedex5e_API.Resources;

public class InvalidResourcePathException : Exception
{
    public InvalidResourcePathException(string file)
        : base($"Could not create a resource path for the requested file '{file}'") { }
}
