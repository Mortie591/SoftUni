using System;
using System.Linq;

namespace _7.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int[] secondArray = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int sum = 0;
            bool isItTrue = false;
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray[i]==secondArray[i])
                {
                    isItTrue = true;
                    sum += firstArray[i];
                }
                else
                {
                    isItTrue=false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");

                    break;
                }
            }
            if (isItTrue==true)
            {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
