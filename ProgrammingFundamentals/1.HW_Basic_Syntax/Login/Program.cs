using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPass = null;
            string password = null;

            for (int i = username.Length-1; i>= 0; i--)
            {
                correctPass += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                password = Console.ReadLine();
                if (password!=correctPass && i<=3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password != correctPass)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
