using System;

namespace Aula_02_Teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello,{name} , on {date: d} at {date:t} !");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(false);
        }
    }
}
