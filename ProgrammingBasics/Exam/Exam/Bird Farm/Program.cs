using System;

namespace Bird_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggPrice = int.Parse(Console.ReadLine());
            int chickensNumberFirstMonth = int.Parse(Console.ReadLine());
            int chickensNumberSecondMonth = int.Parse(Console.ReadLine());
            int chickensNumberThirdMonth = int.Parse(Console.ReadLine());

            double eggPerChickenFirstMonth = chickensNumberFirstMonth*20;
            double eggPerChickenSecondMonth = (chickensNumberFirstMonth+chickensNumberSecondMonth) * 20;
            double eggPerChickenThirdMonth = (chickensNumberFirstMonth+ chickensNumberSecondMonth+ chickensNumberThirdMonth) * 20;
            double sum = eggPerChickenFirstMonth + eggPerChickenSecondMonth + eggPerChickenThirdMonth;
            //Console.WriteLine(sum);
            double totalSum = Math.Floor((sum - sum * 0.04)*(eggPrice*0.01));
            Console.WriteLine($"Profit: {totalSum} Lv.");
        }
    }
}
