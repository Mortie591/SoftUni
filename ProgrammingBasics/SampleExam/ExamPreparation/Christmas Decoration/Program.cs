using System;

namespace Christmas_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int Budget = int.Parse(Console.ReadLine());
            string decoration = Console.ReadLine();
            int totalSum = 0;

            while (decoration!="Stop")
            {
                int sum = 0;

                for (int index = 0; index < decoration.Length; index++)
                {
                    sum+= decoration[index];

                }
                totalSum += sum;
                
               // Console.WriteLine(totalSum);
                if (Budget>=totalSum)
                {
                    Console.WriteLine("Item successfully purchased!");
                }
                else if (Budget < totalSum)
                {
                    Console.WriteLine("Not enough money!");
                    return;
                }
                decoration = Console.ReadLine();
            }
            Console.WriteLine($"Money left: {Budget-totalSum}");
        }
    }
}
