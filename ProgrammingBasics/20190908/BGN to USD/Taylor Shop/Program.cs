using System;

namespace Taylor_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tlength = double.Parse(Console.ReadLine());
            double twidth = double.Parse(Console.ReadLine());

            double area1 = tables * ((tlength+2*0.30) * (twidth+2*0.30));
            double area2= tables * ((tlength/2)* (tlength / 2));

            double usd1 = area1 * 7;
            double usd2 = area2 * 9;

            Console.WriteLine($"{usd1+usd2:f2} USD");
            Console.WriteLine($"{1.85*(usd1 + usd2):f2} BGN");
        }
    }
}
