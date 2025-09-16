namespace Tuples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = (Name: "Alice", Age: 30, IsEmployed: true);

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Employed: {person.IsEmployed}");

            var (name, age, isEmployed) = person;
            Console.WriteLine($"Name: {name}, Age: {age}, Employed: {isEmployed}");
            Console.WriteLine(person.Item1 + " " + person.Item2 + " " + person.Item3);
            
            Tuple<string, int, bool> tuple = new Tuple<string, int, bool>(name, age, isEmployed);
            var tuple2 = new Tuple<string, int, bool>(name, age, isEmployed);
            
            Console.WriteLine(tuple.Equals(tuple2));
        }
    }
}