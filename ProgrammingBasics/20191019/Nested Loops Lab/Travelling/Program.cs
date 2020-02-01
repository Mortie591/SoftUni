using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double moneyNeeded = double.Parse(Console.ReadLine());
            while (destination != "End")
            {
                double moneySaved = 0;

                while (moneyNeeded >= moneySaved)
                {
                    moneySaved += double.Parse(Console.ReadLine());
                    if (moneySaved >= moneyNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                moneyNeeded = double.Parse(Console.ReadLine());
            }
        }
        
    }
}
