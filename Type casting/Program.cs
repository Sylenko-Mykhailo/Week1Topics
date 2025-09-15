namespace Type_casting;

public class Type_casting
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

        int myInt = 100;
        long myLong = myInt;
        Console.WriteLine($"int to long: myInt = {myInt}, myLong = {myLong}");

        float myFloat = 3.14f;
        double myDouble = myFloat;
        Console.WriteLine($"float to double: myFloat = {myFloat}, myDouble = {myDouble}");
    }
    
    public static void DemonstrateExplicitCasting()
    {
        Console.WriteLine("\n--- Explicit Casting ---");

        long myLong = 2147483648L;
        int myInt = (int)myLong;
        Console.WriteLine($"long to int with overflow: myLong = {myLong}, myInt = {myInt}");

        double myDouble = 9.99;
        int anotherInt = (int)myDouble;
        Console.WriteLine($"double to int: myDouble = {myDouble}, anotherInt = {anotherInt}");
    }
    
    public static void DemonstrateConvertClass()
    {
        Console.WriteLine("\n--- Convert.To... ---");
        string numberString = "123";

        int convertedInt = Convert.ToInt32(numberString);
        Console.WriteLine($"Successfully converted '{numberString}' to int: {convertedInt}");

        string invalidString = "abc";
        try
        {
            int failedConversion = Convert.ToInt32(invalidString);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Failed to convert '{invalidString}' using Convert.To: {ex.Message}");
        }
    }
    
    public static void DemonstrateParseMethod()
    {
        Console.WriteLine("\n--- Parse Method ---");
        string numberString = "456";

        int parsedInt = int.Parse(numberString);
        Console.WriteLine($"Successfully parsed '{numberString}' to int: {parsedInt}");

        string invalidString = "Hello";
        try
        {
            int failedParse = int.Parse(invalidString);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Failed to parse '{invalidString}': {ex.Message}");
        }
    }
    
    public static void DemonstrateTryParseMethod()
    {
        Console.WriteLine("\n--- TryParse Method ---");
        string validNumberString = "789";
        string invalidNumberString = "xyz";

        if (int.TryParse(validNumberString, out int tryParsedInt))
        {
            Console.WriteLine($"Successfully tried to parse '{validNumberString}' to int: {tryParsedInt}");
        }
        else
        {
            Console.WriteLine($"Failed to parse '{validNumberString}'.");
        }

        if (int.TryParse(invalidNumberString, out int failedParse))
        {
            Console.WriteLine($"Successfully tried to parse '{invalidNumberString}' to int: {failedParse}");
        }
        else
        {
            Console.WriteLine($"Failed to parse '{invalidNumberString}'. The 'out' parameter value is {failedParse}.");
        }
    }
    
}

