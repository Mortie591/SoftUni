using System;

namespace Cinema_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int freeSeats = int.Parse(Console.ReadLine());
            double totalSum = 0;
            int studentCounter = 0;
            int standardCounter = 0;
            int kidsCounter = 0;

            while (movieName!="Finish")
            {
                int Standard = 0;
                int Student = 0;
                int Kid = 0;
                double sum = 0;

                for (int currentSeat = 1; currentSeat <= freeSeats; currentSeat++)
                {
                    string ticketType = Console.ReadLine();
                   
                    
                    if (ticketType == "standard")
                    {
                        Standard++;
                    }
                    else if (ticketType == "student")
                    {
                        Student++;
                    }
                    else if (ticketType == "kid")
                    {
                        Kid++;
                    }
                    else
                    {
                        break;
                    }

                }
                sum = Standard + Student + Kid;
                Console.WriteLine($"{movieName} - {(sum / freeSeats) * 100:f2}% full.");
                studentCounter += Student;
                standardCounter += Standard;
                kidsCounter += Kid;
               totalSum += sum;
                movieName = Console.ReadLine();
                if (movieName=="Finish")
                {
                    break;
                }
                freeSeats = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Total tickets: {totalSum}");
            Console.WriteLine($"{(studentCounter/totalSum)*100:f2}% student tickets.");
            Console.WriteLine($"{(standardCounter / totalSum) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidsCounter / totalSum) * 100:f2}% kids tickets.");

        }
    }
}
