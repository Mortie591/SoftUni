using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double Pi = Math.PI;
            double area = r * r * Pi;
            double perimeter = 2 * Pi * r;
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
