using System;

namespace Smart_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int money = 0;
            int savedSum = 0;
            int toyNumber = 0;

            for (int i = 1; i <= age; i++)
            {

                if (i%2==0)
                {
                    money+= 10;
                    savedSum += money-1;
                }
                else
                {
                    toyNumber += 1;
                }
            }
            double ownedMoney = toyPrice * toyNumber + savedSum;
            //Console.WriteLine(savedSum);
            //Console.WriteLine(toyNumber*toyPrice);
            // Console.WriteLine(ownedMoney);
            //Console.WriteLine(Math.Abs(ownedMoney-moneyNeeded));
            if ((ownedMoney - moneyNeeded)>=0)
            { 
            Console.WriteLine($"Yes! {Math.Abs(ownedMoney-moneyNeeded):f2}");
            }
            else
            { 
            Console.WriteLine($"No! {Math.Abs(ownedMoney - moneyNeeded):f2}");
            }
        }
    }
}
