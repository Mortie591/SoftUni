using System;

namespace WaterOverflaw
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sumOfLitres=0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                int litresInput = int.Parse(Console.ReadLine());
                sumOfLitres += litresInput;
                if (sumOfLitres>255)
                {
                    sumOfLitres -= litresInput;
                    Console.WriteLine("Insufficient capacity!");

                }
               
            }
            Console.WriteLine(sumOfLitres);

        }
    }
}
