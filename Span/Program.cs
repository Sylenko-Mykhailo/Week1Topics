
using System.Diagnostics;

namespace Span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            var arr = new int[100000];
            var ArraySize = arr.Length;

            for (int i = 0; i < 100000; i++) arr[i] = i;
            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            
            for (int i = 0; i < ArraySize; i++)
            {
                sum += arr[i];
            }
            stopwatch1.Stop();
            Console.WriteLine($"Array Sum: {sum}, Time taken: {stopwatch1.ElapsedMilliseconds} ms");
            
            sum = 0;
            
            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Span<int> span = stackalloc int[arr.Length];
            for (int i = 0; i < ArraySize; i++)
            {
                span[i] = i;
                sum += span[i];
            }
            stopwatch2.Stop();
            Console.WriteLine($"Span Sum: {sum}, Time taken: {stopwatch2.ElapsedMilliseconds} ms");
        }
    }
}
