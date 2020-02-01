using System;

namespace Devide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
               
                if (num%2==0)
                {
                    c1++;
                }
                if (num % 3 == 0)
                {
                    c2++;
                }
                if (num % 4 == 0)
                {
                    c3++;
                }

            }
            Console.WriteLine($"{(c1/n)*100:f2}%");
            Console.WriteLine($"{(c2 / n)*100:f2}%");
            Console.WriteLine($"{(c3 / n)*100:f2}%");


        }
    }
}
