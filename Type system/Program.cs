using System;

public class InternshipProject
{
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
        int a = 10;
        int b = a;
        a = 20;
        Console.WriteLine($"Value Type (int): a = {a}, b = {b}"); //changes in 'a' do not affect 'b'

        MyClass obj1 = new MyClass { Value = 10 };
        MyClass obj2 = obj1;
        obj1.Value = 20;
        Console.WriteLine($"Reference Type (MyClass): obj1.Value = {obj1.Value}, obj2.Value = {obj2.Value}"); //changes in 'obj1' affect 'obj2'
    }
    class MyClass
    {
        public int Value { get; set; }
    }
    public static void DemonstrateBuiltInTypes()
    {
        int myInt = 42;
        Console.WriteLine($"Integer: {myInt}");

        double myDouble = 3.14159;
        Console.WriteLine($"Double: {myDouble}");

        bool isComplete = true;
        Console.WriteLine($"Boolean: {isComplete}");

        string greeting = "Hello, C#!";
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

    public class Person
    {
        public string Name { get; set; }
        public void SayHello() => Console.WriteLine($"Class: Hi, my name is {Name}.");
    }

    public struct Point
    {
        public int X;
        public int Y;
    }

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

    public static void DemonstrateGenericsAndNullableTypes()
    {
        var intList = new System.Collections.Generic.List<int>();
        intList.Add(1);
        intList.Add(2);
        Console.WriteLine($"Generic List (int): Count is {intList.Count}");

        int? nullableInt = null;
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Nullable int has value: {nullableInt.Value}");
        }
        else
        {
            Console.WriteLine("Nullable int is null.");
        }
    }
}
