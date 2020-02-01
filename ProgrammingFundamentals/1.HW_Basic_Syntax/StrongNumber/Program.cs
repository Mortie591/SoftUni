using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int tempNum = inputNum;
            int digit = 0;
            int factorialSum = 0;

            while (tempNum > 0)
            {

                digit = tempNum % 10;
                tempNum /= 10;
                //Console.WriteLine(digit);

                int digitSum = 1;
                int num2 = digit;
                for (int i = 1; i <= digit; i++)
                {
                    digitSum *= num2;
                    num2--;

                    //Console.WriteLine(i);
                }
                Console.WriteLine(digitSum);
                factorialSum += digitSum;
            }
            //Console.WriteLine(factorialSum);
            if (factorialSum == inputNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
