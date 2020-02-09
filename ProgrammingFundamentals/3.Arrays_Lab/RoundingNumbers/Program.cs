using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().
                Split().
                Select(double.Parse).
                ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                double number = array[i];
                number = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {number}");
            }
        }
    }
}
