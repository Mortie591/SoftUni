using System;

namespace ExamPreparation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFailedAttempts = int.Parse(Console.ReadLine());
            int numberOfSuccessfulAttempts = 0;
            int failedAttemptsCounter = 0;
            double sumOfGrades = 0;
            string lastProblemName = "";
            bool doesHeFails = true;

            while (failedAttemptsCounter < numberOfFailedAttempts)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    doesHeFails = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedAttemptsCounter++;
                }
                numberOfSuccessfulAttempts++;
                sumOfGrades += grade;
                lastProblemName = problemName;

            }
            if(doesHeFails)
            {
                Console.WriteLine($"You need a break, {numberOfFailedAttempts} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumOfGrades/numberOfSuccessfulAttempts :f2}");
                Console.WriteLine($"Number of problems: {numberOfSuccessfulAttempts}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }

        }
    }
}
