using System;

namespace BGN_to_USD
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
       
            Console.WriteLine($"{1.79549*USD:f2}");
        }
    }
}
