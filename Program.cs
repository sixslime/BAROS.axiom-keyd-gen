namespace SixSlime.AxiomKeydGen;

internal class Program
{
    static int Main(string[] args)
    {
        try
        {
            var input = Console.In.ReadToEnd();
            var config = new ParsedConfig(input);
            Console.Write(KeydGenerator.Generate(config));
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            return e is Tomlyn.TomlException or ProgramException ? 1 : 2;
        }

        return 0;
    }
}