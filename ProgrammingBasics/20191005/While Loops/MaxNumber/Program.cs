using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int counter = 0;
            int max = int.MinValue;
            while (counter<n)
            {

                number = int.Parse(Console.ReadLine());
                counter++;
                if (number>max)
                {
                    max=number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
