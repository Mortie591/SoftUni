using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationBudget = double.Parse(Console.ReadLine());
            double accountBalance= double.Parse(Console.ReadLine());
            int days = 0;
            int spendingDays = 0;
            while (spendingDays<5 && accountBalance<vacationBudget)
            {
                string action = Console.ReadLine();
                double payment = double.Parse(Console.ReadLine());
                days++;
                if (action == "save")
                {
                    accountBalance += payment;
                    spendingDays = 0;
                }

                if (action=="spend")
                {
                    accountBalance-= payment;
                    spendingDays += 1;
                    if (accountBalance<0)
                    {
                        accountBalance = 0;
                    }
                   
                }
                
            }
            if (accountBalance>=vacationBudget)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            if (spendingDays==5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }

        }
    }
}
