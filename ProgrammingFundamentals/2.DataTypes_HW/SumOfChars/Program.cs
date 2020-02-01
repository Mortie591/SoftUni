using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                char input = Console.ReadLine()[0];
                result += (int)(input);
            }

            Console.WriteLine($"The sum equals: {result}");


        }
    }
}
