
namespace Enums
{
    public enum DayOfWeek : byte
    {
        Sunday,
        Monday,
        Tuesday = 251,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine($"Today is: {today}");

            if (today == DayOfWeek.Wednesday)
            {
                Console.WriteLine("It's midweek!");
            }
            Console.WriteLine($"Numeric value of  is {(byte)System.DayOfWeek.Friday}");
            
            
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"{day} = {(byte)day}");
            }
        }
    }
}

