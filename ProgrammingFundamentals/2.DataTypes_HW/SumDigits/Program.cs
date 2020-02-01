using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int inputNumber = input;
            int digitSum = 0;
            while (inputNumber>0)
            {
                int digit = inputNumber % 10;
                inputNumber /= 10;
                digitSum += digit;
            }
            Console.WriteLine(digitSum);

        }
    }
}
