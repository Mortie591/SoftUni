using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                input = int.Parse(Console.ReadLine());
                int currentN = input;
                if (currentN>result)
                {
                    result = currentN;
                }

            }
            Console.WriteLine(result);
        }
    }
}
