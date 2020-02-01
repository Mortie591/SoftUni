using System;

namespace Equal_Sums_Even_and_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());//100000
            int endNumber = int.Parse(Console.ReadLine());//100001

            for (int number = startNumber; number <= endNumber; number++)
            {
                int currentNumber = number;
                int sumOdd = 0;
                int sumEven = 0;
                for (int i = 0; i < 6; i++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;

                    if (i % 2 == 0)
                    {
                        sumOdd += currentDigit;
                    }
                    else
                    {
                        
                        sumEven += currentDigit;
                    }
                }
                if (sumEven==sumOdd)
                {
                    Console.Write($"{number} ");
                    //Console.WriteLine(sumOdd);
                    //Console.WriteLine(sumEven);

                }

            }

        }
    }
}
