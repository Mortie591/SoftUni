using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            while(steps<10000)
            {
                string command = Console.ReadLine();
               
                if (command=="Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    steps += int.Parse(command);
                }
            }
            if (steps>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000-steps} more steps to reach goal.");
            }
        }
    }
}
