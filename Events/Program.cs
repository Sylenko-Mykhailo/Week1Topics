using Events.Events;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Demonstrating Events ---");

        var heater = new Heater();
        var logger = new Logger();

        heater.OnTemperatureReached += logger.HandleTemperatureReached;

        heater.Heat(100);
    }
}