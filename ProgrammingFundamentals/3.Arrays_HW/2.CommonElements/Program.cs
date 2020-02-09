using System;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //NB equal length?

            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            //more than one common elements??
            string result = " ";
            foreach (var word1 in arr2)
            {
                foreach (var word2 in arr1)
                {
                    if (word1==word2)
                    {
                        result += word1 + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
