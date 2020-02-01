using System;

namespace Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;

            if (destination == "Cairo")
            {
                moneyNeeded = (nights * 250) * 2 + 600;
                if (nights >= 1 && nights <5)
                {
                    moneyNeeded *= 0.97;
                }
                else if (nights >= 5 && nights < 10)
                {
                    moneyNeeded *= 0.95;
                }
                else if (nights >= 10 && nights <25)
                {
                    moneyNeeded *= 0.9;
                }
                else if (nights >= 25 && nights <50)
                {
                    moneyNeeded *= 0.83;
                }
                else if(nights>=50)
                {
                    moneyNeeded *= 0.7;
                }

            }
            if (destination == "Paris")
            {
                moneyNeeded = (nights * 150) * 2 + 350;

                if (nights >= 5 && nights <10)
                {
                    moneyNeeded *= 0.93;
                }
                else if (nights >= 10 && nights <25)
                {
                    moneyNeeded *= 0.88;
                }
                else if (nights >= 25 && nights <50)
                {
                    moneyNeeded *= 0.78;
                }
                else if (nights >= 50)
                {
                    moneyNeeded *= 0.7;
                }

            }
            if (destination == "Lima")
            {
                moneyNeeded = (nights * 400) * 2 + 850;

                if (nights >= 25 && nights <50)
                {
                    moneyNeeded *= 0.81;
                }
                else if (nights >= 50)
                {
                    moneyNeeded *= 0.7;
                }
            }
            if (destination == "New York")
            {
                moneyNeeded = (nights * 300) * 2 + 650;
                if (nights >= 1 && nights <5)
                {
                    moneyNeeded *= 0.97;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    moneyNeeded *= 0.95;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    moneyNeeded *= 0.88;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    moneyNeeded *= 0.81;
                }
                else if (nights >= 50)
                {
                    moneyNeeded *= 0.7;
                }

            }
            if (destination == "Tokyo")
            {
                moneyNeeded = (nights * 350) * 2 + 700;

                if (nights >= 10 && nights <= 24)
                {
                    moneyNeeded *= 0.88;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    moneyNeeded *= 0.83;
                }
                else if (nights >= 50)
                {
                    moneyNeeded *= 0.7;
                }
            }
            if (budget>=moneyNeeded)
            {
                Console.WriteLine($"Yes! You have {(budget-moneyNeeded):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(moneyNeeded-budget):f2} leva.");

            }
        }
    }
}
