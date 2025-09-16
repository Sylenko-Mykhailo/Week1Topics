using System;
using Exceptions.Exception;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[2]);
                throw new MyException("This is a custom exception.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index out of range: {ex.Message}");
                Console.WriteLine($"An exception occurred:  {ex.StackTrace}");
            }
            catch (MyException ex)
            {
                Console.WriteLine($"Custom exception caught: {ex.Message}");
                Console.WriteLine($"An exception occurred:  {ex.StackTrace}");
                throw;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An error occurred:  {ex.Message}");
                
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}

