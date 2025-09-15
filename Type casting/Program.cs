namespace Type_casting;

public class Program
{
    public static void Main()
    {
        DemonstrateImplicitCasting();
        DemonstrateExplicitCasting();
        DemonstrateConvertClass();
        DemonstrateParseMethod();
        DemonstrateTryParseMethod();
    }

    public static void DemonstrateImplicitCasting()
    {
        Console.WriteLine("\n--- Implicit Casting ---");

        var myInt = 100;
        long myLong = myInt;
        Console.WriteLine($"int to long: myInt = {myInt}, myLong = {myLong}");

        var myFloat = 3.14f;
        double myDouble = myFloat;
        Console.WriteLine($"float to double: myFloat = {myFloat}, myDouble = {myDouble}");
    }

    public static void DemonstrateExplicitCasting()
    {
        Console.WriteLine("\n--- Explicit Casting ---");

        var myLong = 2147483648L;
        var myInt = (int)myLong;
        Console.WriteLine($"long to int with overflow: myLong = {myLong}, myInt = {myInt}");

        var myDouble = 9.99;
        var anotherInt = (int)myDouble;
        Console.WriteLine($"double to int: myDouble = {myDouble}, anotherInt = {anotherInt}");
    }

    public static void DemonstrateConvertClass()
    {
        Console.WriteLine("\n--- Convert.To... ---");
        var numberString = "123";

        var convertedInt = Convert.ToInt32(numberString);
        Console.WriteLine($"Successfully converted '{numberString}' to int: {convertedInt}");

        var invalidString = "abc";
        try
        {
            var failedConversion = Convert.ToInt32(invalidString);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Failed to convert '{invalidString}' using Convert.To: {ex.Message}");
        }
    }

    public static void DemonstrateParseMethod()
    {
        Console.WriteLine("\n--- Parse Method ---");
        var numberString = "456";

        var parsedInt = int.Parse(numberString);
        Console.WriteLine($"Successfully parsed '{numberString}' to int: {parsedInt}");

        var invalidString = "Hello";
        try
        {
            var failedParse = int.Parse(invalidString);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Failed to parse '{invalidString}': {ex.Message}");
        }
    }

    public static void DemonstrateTryParseMethod()
    {
        Console.WriteLine("\n--- TryParse Method ---");
        var validNumberString = "789";
        var invalidNumberString = "xyz";

        if (int.TryParse(validNumberString, out var tryParsedInt))
            Console.WriteLine($"Successfully tried to parse '{validNumberString}' to int: {tryParsedInt}");
        else
            Console.WriteLine($"Failed to parse '{validNumberString}'.");

        if (int.TryParse(invalidNumberString, out var failedParse))
            Console.WriteLine($"Successfully tried to parse '{invalidNumberString}' to int: {failedParse}");
        else
            Console.WriteLine($"Failed to parse '{invalidNumberString}'. The 'out' parameter value is {failedParse}.");
    }
}