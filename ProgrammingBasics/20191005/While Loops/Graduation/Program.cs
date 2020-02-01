using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            double grade = 0;
            int counter = 0;
            double sum =0;
            while (counter<12)
            {
                grade = double.Parse(Console.ReadLine());
                counter++;

                if (grade<4.00)
                {
                    --counter;
                    grade = 0;
                }
                sum += grade;

            }
            Console.WriteLine($"{student} graduated. Average grade: {sum/counter:f2}");
        }
    }
}
