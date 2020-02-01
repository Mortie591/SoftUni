using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double whiskeyMoney = whiskeyPrice * whiskey;
            Console.WriteLine(whiskeyMoney);
            double rakiaPrice =(whiskeyPrice / 2)*rakia;
            Console.WriteLine(rakiaPrice);
            double winePrice = wine * (((rakiaPrice/rakia) / 100) * 60);
            Console.WriteLine(winePrice);
            double beerPrice = beer*(((rakiaPrice /rakia)/ 100) * 20);
            Console.WriteLine(beerPrice);
            double moneyNeeded = whiskeyMoney + rakiaPrice + winePrice + beerPrice;
            Console.WriteLine($"{moneyNeeded:f2}");
        }
    }
}
