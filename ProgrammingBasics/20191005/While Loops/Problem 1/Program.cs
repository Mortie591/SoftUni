using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password, thanks");
            string password = Console.ReadLine();
            int wrongInput = 0;
            while (password!="Pass123")
            {
                wrongInput++;
                
                if (wrongInput==3)
                {
                    Console.WriteLine("Sorry, Bro, try again later");
                    break;
                }
                Console.WriteLine($"{password} - wrong!");
                password = Console.ReadLine();
            }
        }
    }
}
