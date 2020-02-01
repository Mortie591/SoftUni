using System;

namespace Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int moneyEarned = 0;
            string command ="";
            string commandType= "";
            while (moneyEarned<goal || command!="closed")
            {
                command = Console.ReadLine();
                int sum = 0;
                if (moneyEarned >= goal)
                {
                    break;
                }
                if (command=="haircut")
                {
                    commandType = Console.ReadLine();
                    if (commandType=="mens")
                    {
                        sum += 15;
                    }
                    else if (commandType == "ladies")
                    {
                        sum += 20;
                    }
                    else if (commandType == "kids")
                    {
                        sum += 10;
                    }
                }
                else if (command == "color")
                {
                    commandType = Console.ReadLine();
                    if (commandType == "touch up")
                    {
                        sum += 20;
                    }
                    else if (commandType == "full color")
                    {
                        sum += 30;
                    }
                    
                }
                
                else if (command=="closed")
                {
                    break;
                }
                moneyEarned += sum;

                if (moneyEarned>=goal)
                {
                    break;
                }
                

            }
            if (moneyEarned >= goal)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }
            else 
            {
                Console.WriteLine($"Target not reached! You need {goal-moneyEarned}lv. more.");
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }
        }
    }
}
