using System;

namespace Events.Events
{
    public class Logger
    {
        public void HandleTemperatureReached(object sender, TemperatureEventArgs e)
        {
            Console.WriteLine($"\n[Logger]: High temperature event received!");
            Console.WriteLine($"[Logger]: The temperature has reached {e.CurrentTemperature}°C.");
        }
    }
}