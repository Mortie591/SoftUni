using System;

namespace Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int gamesCounter = int.Parse(Console.ReadLine());
            int penaltiesCounter = 0;
            int addTimeCounter = 0;
            double totalTime = 0;
            for (int i = 1; i <=gamesCounter; i++)
            {
                int time = int.Parse(Console.ReadLine());

                if (time>90 && time<=120)
                {
                    addTimeCounter ++;
                }

                else if (time > 120)
                {
                    penaltiesCounter ++;
                }
                totalTime += time;
                
            }
            double averageTime = totalTime / gamesCounter;
            Console.WriteLine($"{team} has played {totalTime} minutes. Average minutes per game: {averageTime:f2}");
            Console.WriteLine($"Games with penalties: {penaltiesCounter}");
            Console.WriteLine($"Games with additional time: {addTimeCounter}");
        }
    }
}
