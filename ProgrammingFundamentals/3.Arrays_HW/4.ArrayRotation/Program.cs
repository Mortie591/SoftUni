using System;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());
            //How to rotate the array?! TempString
            //How to simplify the problem, so we don't rotate as many
            //times as the given number but only as much as it's necessary
            count = count % input.Length;
            for (int c = 0; c < count; c++)
            {
            string temp = input[0];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }

                input[input.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
