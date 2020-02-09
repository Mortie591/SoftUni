using System;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int input = int.Parse(Console.ReadLine());
            if (input > 0 && input <= 7)
            {
                Console.WriteLine(daysOfWeek[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
