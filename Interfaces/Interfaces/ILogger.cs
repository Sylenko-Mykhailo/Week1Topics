namespace Interfaces.Interfaces
{
    public interface ILogger
    {
        private void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        int MaxLogSize { get; }
    }
}