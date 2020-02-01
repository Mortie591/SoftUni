using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int a = 1;
            
            while (a<=num)
            {
                Console.WriteLine(a);
                a=2*a + 1;
            }

        }
    }
}
