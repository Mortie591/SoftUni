﻿using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity =double.Parse( Console.ReadLine());

            if(city=="Sofia")
            {
                if(product=="coffee")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
        }
        
    }
}
