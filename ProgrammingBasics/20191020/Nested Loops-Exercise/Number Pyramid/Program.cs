using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int row = 1; row <=n; row++)
            {

                for (int col = 1; col <=row; col++)
                {
                    num += 1;

                    Console.Write($"{num} ");

                    if (num==n)
                    {
                        return;
                    }
                }


                Console.WriteLine();
            }
        }
    }
}
