using System;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int a = 1; a <=10; a++)
                {
                    Console.WriteLine($"{i} * {a} = {i*a}");
                }
            }
        }
    }
}
