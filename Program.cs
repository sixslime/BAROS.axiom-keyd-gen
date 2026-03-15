namespace SixSlime.AxiomKeydGen;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            var input = Console.In.ReadToEnd();
            var config = new ParsedConfig(input);
            Console.Write(KeydGenerator.Generate(config));
        }
        catch (Exception e)
        {
            if (e is not (Tomlyn.TomlException or ProgramException)) throw;
            Console.Error.Write(e.Message);
        }
        
    }
}