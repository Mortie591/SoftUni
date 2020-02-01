using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int num = firstNumber; num <= secondNumber; num++)
            {
                int firstSum = 0;
                int secondSum = 0;
                int thirdNumber = 0;
                string numberAsString = num.ToString();
                for (int i = 0; i <numberAsString.Length; i++)
                {
                    int index = int.Parse(numberAsString[i].ToString());

                    if (i<=1)
                    {
                        firstSum += index;
                        //Console.Write($"{firstSum}");
                    }
                   else if (i >= 3)
                    {
                        secondSum += index;
                       // Console.Write($"{secondSum}");
                    }
                    else
                    {
                        thirdNumber = int.Parse(numberAsString[2].ToString());
                    }

                }

                if (firstSum==secondSum)
                {
                    Console.Write($"{num} ");
                }
                else
                {
                    if (firstSum>secondSum)
                    {
                        secondSum += thirdNumber;
                        if (firstSum==secondSum)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    else 
                    {
                        firstSum += thirdNumber;
                        if (firstSum == secondSum)
                        {
                            Console.Write($"{num} ");
                        }

                    }
                }
            }
        }
    }
}
