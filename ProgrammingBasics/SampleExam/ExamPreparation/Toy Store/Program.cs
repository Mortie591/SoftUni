using System;

namespace Toy_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int counter = puzzles + dolls + teddyBears + minions + trucks;
            double puzzlePrice = puzzles * 2.60;
            double dollPrice = dolls * 3.00;
            double teddyBearsPrice = teddyBears * 4.10;
            double minionsPrice = minions * 8.20;
            double truckPrice = trucks * 2.00;
            double income = puzzlePrice + dollPrice + teddyBearsPrice + minionsPrice + truckPrice;
            if (counter>=50)
            {
                income = income - (income / 100) * 25;
                income= income - (income / 100) * 10;
            }
            else
            {
                income = income - (income / 100) * 10;

            }
            if (income>=vacationPrice)
            {
                Console.WriteLine($"Yes! {(income-vacationPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vacationPrice-income):f2} lv needed.");

            }


        }
    }
}
