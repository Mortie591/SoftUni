using System;

namespace Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double total = 0;
            if (stage=="Quarter final")
            {
                if (ticketType=="Standard")
                {
                    total = numberOfTickets * 55.50;
                }
                else if (ticketType == "Premium")
                {
                    total = numberOfTickets * 105.20;

                }
                if (ticketType == "VIP")
                {
                    total = numberOfTickets * 118.9;

                }
            }
            else if (stage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    total = numberOfTickets * 75.88;
                }
                else if (ticketType == "Premium")
                {
                    total = numberOfTickets * 125.22;

                }
                if (ticketType == "VIP")
                {
                    total = numberOfTickets * 300.40;

                }
            }
            else if (stage == "Final")
            {
                if (ticketType == "Standard")
                {
                    total = numberOfTickets * 110.10;
                }
                else if (ticketType == "Premium")
                {
                    total = numberOfTickets * 160.66;

                }
                if (ticketType == "VIP")
                {
                    total = numberOfTickets * 400;

                }
            }

            if (total>4000)
            {
                total *= 0.75;
            }
            else if(total>2500)
            {
                total *= 0.9;
                if (photo=='Y')
                {
                    total += 40 * numberOfTickets;
                }
               
            }
            else
            {
                total += 40 * numberOfTickets;
            }
            Console.WriteLine($"{total:f2}");

        }
    }
}
