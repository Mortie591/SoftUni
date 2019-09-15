using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            int area= int.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = price * 0.18;
            double finalSum = price - discount;
            Console.WriteLine($"The final price is: {finalSum:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
