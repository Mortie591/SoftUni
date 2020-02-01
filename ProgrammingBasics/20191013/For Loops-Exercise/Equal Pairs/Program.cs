using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int previousPair = 0;
            int secondPair = 0;
            int maxDiff =0;

            for (int i = 1; i <=n; i++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                if (i%2!=0)
                {
                    previousPair = firstNumber + secondNumber;
                }
                else
                {
                    secondPair = firstNumber + secondNumber;
                }
                 maxDiff = Math.Abs(previousPair - secondPair);

            }
            if (maxDiff==0 || n==1)
            {
                Console.WriteLine($"Yes, value={previousPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
