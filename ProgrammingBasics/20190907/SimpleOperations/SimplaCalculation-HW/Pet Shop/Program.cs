using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());
            double sum=dogs*2.5+others*4;
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
