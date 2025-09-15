using Interfaces.Interfaces;

public class Program
{
    // This method accepts any object that implements ILogger
    public static void ProcessLog(ILogger logger)
    {
        //logger.LogMessage("This is a polymorphic log message."); //private
        Console.WriteLine($"Max log size is: {logger.MaxLogSize} bytes.");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Demonstrating Interfaces ---");

        ILogger logger = new ConsoleLogger();

        ProcessLog(logger);

    }
}