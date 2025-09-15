namespace Interfaces.Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"[Console Log]: {message}");
        }

        public int MaxLogSize => 1024;
    }
}