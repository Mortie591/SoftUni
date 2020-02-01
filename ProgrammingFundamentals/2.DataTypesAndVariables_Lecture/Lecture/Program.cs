using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //E.g. of explicit conversion:
            //long x = 247826321213;
            //Console.WriteLine(x); ;
            //int p = (int)x;
            //Console.WriteLine(p);

            //Special number: Exercise

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    int current = i;
            //    int sum = 0;
            //    while (current>0)
            //    {
            //        sum += current % 10;
            //        current /= 10;

            //    }
            //    bool isSpecial = false;
            //    if (sum==5 || sum==7 || sum==11)
            //    {
            //        isSpecial = true;
            //    }
            //    Console.WriteLine($"{i}->{isSpecial}");
            //}

            //CHAR exercise with ASCI Table-Print the English alphabet reversed:

            //for (int i = 1; i <= 26; i++)
            //{
            //    Console.Write((char)(65+26-i)+" ");
            //}

            // Escaping:

            //Console.WriteLine("\thello"); //Tab;
            //Console.WriteLine("\nHEEELLOOOO!!!"); //New line;

            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimiter}{secondName}");
        }
    }
}
