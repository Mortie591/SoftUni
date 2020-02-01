using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day= Console.ReadLine();
            decimal ticketPrice = 0;
            decimal totalPrice = 0;
            decimal priceWithDiscount = 0;


            if (day== "Friday")
            {
                if (group== "Students")
                {
                    ticketPrice = 8.45M;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 30)
                    {
                        priceWithDiscount = totalPrice - totalPrice * 0.15M;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
                else if (group == "Business")
                {
                    ticketPrice = 10.90M;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 100)
                    {
                        priceWithDiscount = totalPrice - 10 * ticketPrice;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
                else if (group == "Regular")
                {
                    ticketPrice = 15;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        priceWithDiscount = totalPrice - totalPrice * 0.05M;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
            }
           else if (day == "Saturday")
            {
                if (group == "Students")
                {
                    ticketPrice = 9.80M;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 30)
                    {
                        priceWithDiscount = totalPrice - totalPrice * 0.15M;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
                else if (group == "Business")
                {
                    ticketPrice = 15.60M;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 100)
                    {
                        priceWithDiscount = totalPrice - 10 * ticketPrice;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
                else if (group == "Regular")
                {
                    ticketPrice = 20;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        priceWithDiscount = totalPrice - totalPrice * 0.05M;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
            }
            else if (day == "Sunday")
            {
                if (group == "Students")
                {
                    ticketPrice = 10.46M;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 30)
                    {
                        priceWithDiscount = totalPrice - totalPrice * 0.15M;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
                else if (group == "Business")
                {
                    ticketPrice = 16;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 100)
                    {
                        priceWithDiscount = totalPrice - 10 * ticketPrice;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
                else if (group == "Regular")
                {
                    ticketPrice = 22.50M;
                    totalPrice = ticketPrice * numberOfPeople;
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        priceWithDiscount = totalPrice - totalPrice * 0.05M;
                        Console.WriteLine($"Total price: {priceWithDiscount:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}");

                    }
                }
            }

            

        }
    }
}
