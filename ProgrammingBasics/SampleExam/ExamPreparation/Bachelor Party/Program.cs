using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int honorar = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int numberOfGuests = 0;
            int totalSum = 0;
            while (command!="The restaurant is full")
            {
                int peopleInGroup = int.Parse(command);
                if (peopleInGroup>=5)
                {
                    totalSum += peopleInGroup * 70;
                }
                else if (peopleInGroup<5)
                {
                    totalSum += peopleInGroup * 100;

                }
                numberOfGuests += peopleInGroup;
                command = Console.ReadLine();
            }
            int moneyLeft = totalSum - honorar;
            if (moneyLeft>=0)
            {
                Console.WriteLine($"You have {numberOfGuests} guests and {moneyLeft} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {numberOfGuests} guests and {Math.Abs(moneyLeft)} leva income, but no singer."
);
            }

        }
    }
}
