using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            int salary= int.Parse(Console.ReadLine());
            int facebookCounter = 0;
            int instagramCounter = 0;
            int redditCounter = 0;
            string tabName = "";

            for (int i = 0; i < n; i++)
            {
                tabName = Console.ReadLine();
                if (tabName=="Facebook")
                {
                    facebookCounter++;
                }
                if (tabName == "Instagram")
                {
                    instagramCounter++;
                }
                if (tabName == "Reddit")
                {
                    redditCounter++;
                }
            }
            salary = salary-((facebookCounter * 150) + (instagramCounter * 100) + (redditCounter * 50));

           // Console.WriteLine(salary);
            //Console.WriteLine(facebookCounter*150);
           // Console.WriteLine(instagramCounter*100);
           // Console.WriteLine(redditCounter*50);
            if (salary>0)
            { 
            Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
