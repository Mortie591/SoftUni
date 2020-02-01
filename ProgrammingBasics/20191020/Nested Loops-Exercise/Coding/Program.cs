using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int number=int.Parse(numberAsString);
            for (int i = 0; i < numberAsString.Length; i++)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit==0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                for (int j = 0; j < currentDigit; j++)
                {
                    int digitAfterAddition = currentDigit + 33;
                    Console.Write($"{(char)digitAfterAddition}");

                }
                Console.WriteLine();
            }
        }
    }
}
