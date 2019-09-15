using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());
            int hours = projectsNumber * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projectsNumber} project/s.");
        }
    }
}
