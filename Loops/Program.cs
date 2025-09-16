
namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For Loop Iteration: {i}");
            }

            // While Loop
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"While Loop Iteration: {j}");
                j++;
            }

            // Do-While Loop
            int k = 0;
            do
            {
                Console.WriteLine($"Do-While Loop Iteration: {k}");
                k++;
            } while (k < 5);

            // Foreach Loop
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }
        }
    }
}
