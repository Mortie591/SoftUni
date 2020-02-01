using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoorGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int grade = 0;
            int counter = 0;
            double sumOfGrades = 0;
            while (problemName!="Enough")
            {
                string lastProblem = problemName;
                problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {sumOfGrades/counter:f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                grade = int.Parse(Console.ReadLine());
                sumOfGrades += grade;
                counter++;
                int poorGradeCounter = 0;
                if (grade<=4)
                {
                    poorGradeCounter++;
                }

                if (grade<=4 && poorGradeCounter==numberOfPoorGrades)
                {
                    Console.WriteLine($"You need a break, {numberOfPoorGrades} poor grades.");
                    break;
                }

            }
            
        }
    }
}
