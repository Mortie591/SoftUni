using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double q = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{ q * 2.5:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{ q * 1.2:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{ q * 0.85:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{ q * 1.45:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{ q * 2.7:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{ q * 5.5:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{ q * 3.85:f2}");
                   
                }
                else
                {
                    Console.WriteLine("error");
                }

            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{ q * 2.7:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{ q * 1.25:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{ q * 0.9:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{ q * 1.60:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{ q * 3.0:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{ q * 5.6:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{ q * 4.2:f2}");
                    
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
