using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string input = Console.ReadLine();
            string pass = Console.ReadLine();


            while (pass!=input)
            {
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
