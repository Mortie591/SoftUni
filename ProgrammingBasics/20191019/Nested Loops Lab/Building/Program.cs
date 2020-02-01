using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int storey = int.Parse(Console.ReadLine());
            int number= int.Parse(Console.ReadLine());
            for (int i = storey; i > 0; i--)
            {
                for (int a = 0; a < number; a++)
                {
                    if(i==storey)
                    {
                        Console.Write($"L{i}{a} ");
                    }
                    if (i % 2 != 0 && i != storey)
                    {
                        Console.Write($"A{i}{a} ");
                        
                    }
                    else if (i % 2 == 0 && i!=storey)
                    {
                        Console.Write($"O{i}{a} ");
                    }
                }
                Console.WriteLine();


            }
        }
    }
}
