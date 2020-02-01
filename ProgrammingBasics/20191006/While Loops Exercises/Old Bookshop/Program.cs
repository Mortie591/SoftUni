using System;

namespace Old_Bookshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Book = Console.ReadLine();
            int Capacity =int.Parse(Console.ReadLine());
            int Counter = 0;
            string bookTitle ="";
            while (bookTitle != Book)
            {
                bookTitle = Console.ReadLine();
                Counter++;

                if (Counter == Capacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {Capacity} books");
                    return;
                }
                
            }  
                Console.WriteLine($"You checked {--Counter} books and found it.");

        }
    }
}
