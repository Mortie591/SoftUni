using System;

namespace LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create nad initialise an Array;

            int[] numbers = new int[10];
            int arrayLangth = numbers.Length;

            //Assign values to an array;

            numbers[2] = 2000;
            numbers[5] = 5000;
            int result1 = numbers[2];
            int result4 = numbers[5];
            int result5 = numbers[6];

            numbers[0] = numbers[2] + numbers[5];

            int result0 = numbers[0];

        }
    }
}
