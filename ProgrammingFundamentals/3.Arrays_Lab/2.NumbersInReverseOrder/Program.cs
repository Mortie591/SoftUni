﻿using System;
using System.Linq;

namespace _2.NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //for (int i=array.Length-1; i>=0; i--)
            //{
            //    Console.Write($"{array[i]} ");

            //}
            array = array.Reverse().ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }


        }
    }
}
