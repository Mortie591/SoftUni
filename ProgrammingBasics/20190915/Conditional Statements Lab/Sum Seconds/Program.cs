﻿using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstTime = int.Parse(Console.ReadLine());
            int SecondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());
            int Total = FirstTime + SecondTime + ThirdTime;
            int minutes = Total / 60;
            int seconds = Total % 60;
            if (seconds<10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
