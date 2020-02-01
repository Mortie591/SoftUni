using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= 2*n; i++)
            {
              
                if (i<=n)
                {
                    int num = int.Parse(Console.ReadLine());
                    leftSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    rightSum += num;
                }
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }


        }
    }
}
