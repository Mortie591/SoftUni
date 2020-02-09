using System;
using System.Linq;
namespace _6.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int sumOddNumbers = 0;
            int sumEvenNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    sumEvenNumbers += numbers[i];
                }
                else
                {
                    sumOddNumbers += numbers[i];

                }
            }
            int result = sumEvenNumbers - sumOddNumbers;

            Console.WriteLine(result);
        }
    }
}
