using System;
using System.Linq;

namespace _4.ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split();
           // arrayOfStrings = arrayOfStrings.Reverse().ToArray();//how to reverse the elements of an array automatically using linq!!

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.Write( $"{arrayOfStrings[arrayOfStrings.Length-i-1]} ");//how to reverse the elements of an array manually!!
            }
        }
    }
}
