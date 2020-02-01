using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            bool isTheBookFound = false;
            int counter = 0;
            
            while(counter<numberOfBooks)
            {
                string nextBook = Console.ReadLine();
                if (nextBook==favouriteBook)
                {
                    isTheBookFound = true;
                    break;
                }
                counter++;
            }
            if (isTheBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
