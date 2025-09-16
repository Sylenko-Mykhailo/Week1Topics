
namespace Events.Events
{
    public class TemperatureEventArgs : EventArgs
    {
        public int CurrentTemperature { get; }
        public TemperatureEventArgs(int temp)
        {
            CurrentTemperature = temp;
        }
    }

    public class Heater
    {
        private int _temperature;

        public event EventHandler<TemperatureEventArgs> OnTemperatureReached;

        public void Heat(int targetTemp)
        {
            Console.WriteLine("Heater is starting...");
            while (_temperature < targetTemp)
            {
                _temperature += 10;
                Console.WriteLine($"Current Temp: {_temperature}°C");
                
                if (_temperature >= 80)
                {
                    OnTemperatureReached?.Invoke(this, new TemperatureEventArgs(_temperature));
                    return;
                }
            }
        }
    }
}