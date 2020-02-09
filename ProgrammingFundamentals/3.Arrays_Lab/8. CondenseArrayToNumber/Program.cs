using System;
using System.Linq;
namespace _8._CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int result = 0;
            bool isItTrue = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length<=1)
                {
                    Console.WriteLine($"{numbers[0]} is already condensed to number");
                    isItTrue = true;
                    break;
                }
                int sum = 0;
                for (int index = i; index < numbers.Length-1; index++)
                {
                    sum = numbers[i] + numbers[i + 1];

                }
                result += sum;
            }
            if (isItTrue==false)
            {
            Console.WriteLine(result);
            }
        }
    }
}
