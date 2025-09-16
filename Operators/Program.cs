
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 25, Result;
            // Bitwise AND Operator (If both of the bits are 1, it gives 1.)
            Result = a & b;
            Console.WriteLine($"Bitwise AND: {Result}");
            // Bitwise OR Operator (If any of the bits is 1, it gives 1.)
            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");
            // Bitwise XOR Operator (If both of the bits are different, it gives 1.)
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");
            
            var boo = true;
            
            var res = boo ? "Boo" : "Not Boo";
            Console.WriteLine(res);
        }
    }
}

