using System;

namespace Trade_Commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double c = 0.0;

            if (city=="Sofia")
            {
                if (s >= 0 && s <= 500)
                {
                    Console.WriteLine($"{c = s * 0.05:f2} ");
                }
                else if (s > 500 && s <= 1000)
                {
                    Console.WriteLine($"{c = s * 0.07:f2} ");
                }
                else if (s > 1000 && s <= 10000)
                {
                    Console.WriteLine($"{c = s * 0.08:f2} ");
                }
                else if (s >10000)
                {
                    Console.WriteLine($"{c = s * 0.12:f2} ");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (s >= 0 && s <= 500)
                {
                    Console.WriteLine($"{c = s * 0.045:f2} ");
                }
                else if (s > 500 && s <= 1000)
                {
                    Console.WriteLine($"{c = s * 0.075:f2} ");
                }
                else if (s > 1000 && s <= 10000)
                {
                    Console.WriteLine($"{c = s * 0.10:f2} ");
                }
                else if (s > 10000)
                {
                    Console.WriteLine($"{c = s * 0.13:f2} ");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (s >= 0 && s <= 500)
                {
                    Console.WriteLine($"{c = s * 0.055:f2} ");
                }
                else if (s > 500 && s <= 1000)
                {
                    Console.WriteLine($"{c = s * 0.08:f2} ");
                }
                else if (s > 1000 && s <= 10000)
                {
                    Console.WriteLine($"{c = s * 0.12:f2} ");
                }
                else if (s > 10000)
                {
                    Console.WriteLine($"{c = s * 0.145:f2} ");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
