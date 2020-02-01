using System;

namespace Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            //int x1 = 0;
            //int x2 = 0;
            int sum = 0;
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                int x1 = 0;
                x1 += i;
                for (int a = start; a <= end; a++)
                {
                    
                    int x2 = 0;
                    x2 += a;
                    sum = x1 + x2;
                    counter++;
                    if (sum==number)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {number})");
                       // Console.Write($"({x1} + {x2} = {number})");
                        return;
                    }
                  
                    
                }
            }
            //if (sum == number)
            //{
            //    Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {number})");

            //}
            //else
            //{
                Console.WriteLine($"{counter} combinations - neither equals {number}");

           // }
        }
    }
}
