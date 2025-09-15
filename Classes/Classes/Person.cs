namespace Classes.Classes
{
    public class Person
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }
}