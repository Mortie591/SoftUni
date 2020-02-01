using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cake = length * width;
            int piece = 0;
            while (piece<=cake)
            {
                string command = Console.ReadLine();
               // Console.WriteLine(piece);
                if (command == "STOP")
                {
                  //  Console.WriteLine($"{cake - piece} are left.");
                    break;
                }
                piece += int.Parse(command);

            }
            if (piece > cake)
            {
                Console.WriteLine($"No more cake left! You need {piece - cake} pieces more.");

            }
            else
            {
                Console.WriteLine($"{cake - piece} pieces are left.");

            }


        }
    }
}
