using Records.Records;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Demonstrating Records ---");

        var emp1 = new Employee(1, "Alice");
        var emp2 = new Employee(1, "Alice");

        var empClass1 = new EmployeeClass { Id = 1, Name = "Alice" };
        var empClass2 = new EmployeeClass { Id = 1, Name = "Alice" };

        Console.WriteLine($"Record equality (value-based): {emp1 == emp2}");
        Console.WriteLine($"Class equality (reference-based): {empClass1 == empClass2}");
        
        Console.WriteLine("\n--- Immutability and the 'with' Expression ---");
        var originalEmployee = new Employee(2, "Bob");
        Console.WriteLine($"Original employee: {originalEmployee}");

        var updatedEmployee = originalEmployee with { Name = "Robert" };

        Console.WriteLine($"Updated employee: {updatedEmployee}");
        Console.WriteLine($"Original employee (unmodified): {originalEmployee}");
    }
}

public class EmployeeClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}