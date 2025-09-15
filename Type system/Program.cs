namespace Type_system;

public class Program
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main(string[] args)
    {
        DemonstrateValueAndReferenceTypes();
        Console.WriteLine("\n\n\n");

        DemonstrateBuiltInTypes();
        Console.WriteLine("\n\n\n");

        DemonstrateCustomTypes();
        Console.WriteLine("\n\n\n");

        DemonstrateGenericsAndNullableTypes();
    }

    public static void DemonstrateValueAndReferenceTypes()
    {
        var a = 10;
        var b = a;
        a = 20;
        Console.WriteLine($"Value Type (int): a = {a}, b = {b}"); //changes in 'a' do not affect 'b'

        var obj1 = new MyClass { Value = 10 };
        var obj2 = obj1;
        obj1.Value = 20;
        Console.WriteLine(
            $"Reference Type (MyClass): obj1.Value = {obj1.Value}, obj2.Value = {obj2.Value}"); //changes in 'obj1' affect 'obj2'
    }

    public static void DemonstrateBuiltInTypes()
    {
        var myInt = 42;
        Console.WriteLine($"Integer: {myInt}");

        var myDouble = 3.14159;
        Console.WriteLine($"Double: {myDouble}");

        var isComplete = true;
        Console.WriteLine($"Boolean: {isComplete}");

        var greeting = "Hello, C#!";
        Console.WriteLine($"String: {greeting}");
    }

    public static void DemonstrateCustomTypes()
    {
        var person = new Person { Name = "Alice" };
        person.SayHello();

        var point = new Point { X = 10, Y = 20 };
        Console.WriteLine($"Struct (Point): ({point.X}, {point.Y})");

        var weekendDay = DayOfWeek.Saturday;
        Console.WriteLine($"Enum: The weekend day is {weekendDay}");
    }

    public static void DemonstrateGenericsAndNullableTypes()
    {
        var intList = new List<int>();
        intList.Add(1);
        intList.Add(2);
        Console.WriteLine($"Generic List (int): Count is {intList.Count}");

        int? nullableInt = null;
        if (nullableInt.HasValue)
            Console.WriteLine($"Nullable int has value: {nullableInt.Value}");
        else
            Console.WriteLine("Nullable int is null.");
    }

    private class MyClass
    {
        public int Value { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Class: Hi, my name is {Name}.");
        }
    }

    public struct Point
    {
        public int X;
        public int Y;
    }
}