using System;

namespace BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double earnings = double.Parse(Console.ReadLine());
            double profit = double.Parse(Console.ReadLine());
            double expences = double.Parse(Console.ReadLine());
            double giftMoney = double.Parse(Console.ReadLine());

            double totalSum = 5 * (profit + earnings) - expences;

            if (giftMoney<=totalSum)
            {
                Console.WriteLine($"Profit: {totalSum:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(giftMoney- totalSum):f2} BGN.");
            }
        }
    }
}
