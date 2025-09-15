namespace Namespace.Services
{
    public class MyLogger
    {
        public void LogServiceRequest(string request)
        {
            Console.WriteLine($"[SERVICE LOG] Request received: {request}");
        }
    }
}