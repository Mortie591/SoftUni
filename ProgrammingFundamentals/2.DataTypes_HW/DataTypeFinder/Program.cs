﻿using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int division = sum / num3;
            int result = division * num4;
            Console.WriteLine(result);
        }
    }
}
