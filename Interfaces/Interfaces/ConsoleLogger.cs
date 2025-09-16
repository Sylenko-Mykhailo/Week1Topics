namespace Interfaces.Interfaces
{
    public class ConsoleLogger : ILogger
    {
        private void LogMessage(string message)
        {
            Console.WriteLine($"[Console Log]: {message}");
        }

        public int MaxLogSize => 1024;
    }
}