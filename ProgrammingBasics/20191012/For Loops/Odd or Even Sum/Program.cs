using System;

namespace Odd_or_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= n; i++)
            {

                if (i%2!=0)
                {
                    int num = int.Parse(Console.ReadLine());
                    oddSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    evenSum += num;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }

        }
    }
}
