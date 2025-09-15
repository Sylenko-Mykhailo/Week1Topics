namespace Classes.Classes
{
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Driving the {Manufacturer} {Model}.");
        }
    }
}