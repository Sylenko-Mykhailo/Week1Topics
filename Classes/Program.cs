using Classes.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        var person1 = new Person { Name = "Alice" };
        person1.SayHello();

        Person person2 = person1;
        person2.Name = "Bob";
        Console.WriteLine($"Name after change: {person1.Name}");
        
        Console.WriteLine("\n--- Inheritance Example ---");
        var myCar = new Car { Manufacturer = "Honda", Model = "Civic", Year = 2022 };
        myCar.Drive();
        Console.WriteLine($"My car is a {myCar.Year} {myCar.Manufacturer}.");
    }
}