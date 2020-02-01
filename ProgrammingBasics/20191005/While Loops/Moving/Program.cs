using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int area = w * l * h;
            int number = 0;
            while (number < area)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                   // number += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    number += int.Parse(command);
                }

            }
            if (number < area)

            {
                Console.WriteLine($"{area - number} Cubic meters left.");
            }
            else
            { 
            Console.WriteLine($"No more free space! You need {number-area} Cubic meters more");
            }
        }
    }
}
