
namespace Anonymous_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Alice", Age = 30 };
            Console.WriteLine(person);

            var product = new { Id = 1, Name = "Laptop", Price = 999.99 };
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            
            var product1 = product with { Price = 899.99 };
            Console.WriteLine(product1);
            
            var apple = new { Item = "apples", Price = 1.35 };
            
            var apple2 = new { Item = "apples", Price = 1.35 };
            Console.WriteLine(apple2.Equals(apple));
            Console.WriteLine(apple2 == apple);

            var peopleList = new List<Person>();
            peopleList.Add(new Person { Name = "John", Surname = "Doe", Age = 25 });
            peopleList.Add(new Person { Name = "Jane", Surname = "Smith", Age = 30 });
            var anonymousPeople = peopleList.Select(p => new { FullName = $"{p.Name} {p.Surname}", p.Age });
            foreach (var p in anonymousPeople)
            {
                Console.WriteLine(p);
            }
        }
    }

    class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        
    }
}

