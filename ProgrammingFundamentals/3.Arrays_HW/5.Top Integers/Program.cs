using System;
using System.Linq;

namespace _5.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(e => int.Parse(e))
                .ToArray();
            string result=null;
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                bool isTopInteger = true;
                for (int index = i+1; index <array.Length; index++)
                {
                    if (current<=array[index])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    result += current + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
