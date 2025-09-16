using Interfaces.Interfaces;

public class Program
{
    public static void ProcessLog(ILogger logger)
    {
        Console.WriteLine($"Max log size is: {logger.MaxLogSize} bytes.");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Demonstrating Interfaces ---");

        ILogger logger = new ConsoleLogger();

        ProcessLog(logger);

    }
}