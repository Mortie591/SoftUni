using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int substituteNumber = inputNumber;

            for (int i = 97; i <97+substituteNumber; i++)
            {
                int a = i;
                char firstLetter = (char)(a);

                for (int j = 97; j <97+ substituteNumber; j++)
                {
                    int b = j;
                    char secondLetter = (char)(b);
                    

                    for (int k = 97; k < 97+substituteNumber; k++)
                    {
                        int c = k;
                        char thirdLetter = (char)(c);
                        Console.Write(firstLetter);
                        Console.Write(secondLetter);
                        Console.Write(thirdLetter);
                        Console.WriteLine();
                    }
                }

            }
            
        }
    }
}
