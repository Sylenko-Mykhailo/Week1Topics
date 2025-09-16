using System;
namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#";
            Console.WriteLine("Switch Statement Started");
            switch (str)
            {
                case "C#":      
                case "Java":
                case "C":
                    Console.WriteLine("It's a Programming Language");
                    break;
                case "MSSQL":
                case "MySQL":
                case "Oracle":
                    Console.WriteLine("It's a Database");
                    break;
                case "MVC":
                case "WEB API":
                    Console.WriteLine("It's a Framework");
                    break;
            }
            Console.WriteLine("Switch Statement Ended");
        }
    }
}