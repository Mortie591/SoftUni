using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <=23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)

                    Console.WriteLine($"{hours}:{minutes}");

                //for (int seconds = 0; seconds <= 59; seconds++)
                //{
                //    Console.WriteLine($"Minutes {hours}:{minutes}:{seconds}");
                //}
            }
        }
          
        
    }
}
