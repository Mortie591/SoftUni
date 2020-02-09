using System;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] numberOfWagons = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                numberOfWagons[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(String.Join(" ",numberOfWagons));
            Console.WriteLine(numberOfWagons.Sum());
        }
    }
}
