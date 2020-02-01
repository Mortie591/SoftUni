using System;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            double grade;
            int counter = 0;
            int failCounter = 0;
            double sum = 0;
            while (counter < 5)
            {
                grade = double.Parse(Console.ReadLine());
                counter++;
                if (grade < 4.00)
                {
                    counter--;
                    grade = 0;
                    ++failCounter;
                }
                if (grade<4.00 && failCounter==2)
                {
                    Console.WriteLine($"{student} has been excluded at {++counter} grade");
                    return;
                }
                sum += grade;

            }
            Console.WriteLine($"{student} graduated. Average grade: {sum / counter:f2}");
        }
    }
}
