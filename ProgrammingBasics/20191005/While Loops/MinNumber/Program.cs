using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int counter = 0;
            int min = int.MaxValue;
            while (counter < n)
            {

                number = int.Parse(Console.ReadLine());
                counter++;
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
