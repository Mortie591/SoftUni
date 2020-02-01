using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volumn = length * width * height;
            double water = volumn-(volumn/100 )* percent ;
            Console.WriteLine($"{water/1000:f3}");
        }
    }
}
