namespace pokedex5e_API.Resources;

internal static class ResourcePath
{
    public static string ForFile(string file)
    {
        var executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var executingPath = Path.GetDirectoryName(executablePath);

        // There's probably no situation where this can go wrong,
        // but it's nullable for some obscure reason so we should handle it just in case.
        if (executingPath == null)
            throw new InvalidResourcePathException(file);

        return Path.Combine(executingPath, $"Resources/{file}");
    }
}
