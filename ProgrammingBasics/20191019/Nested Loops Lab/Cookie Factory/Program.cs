using System;

namespace Cookie_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string command = "";
                int counter = 0;
                bool eggs = false;
                bool flour = false;
                bool sugar = false;


                while (command != "Bake!" || (command != "eggs" && command != "flour" && command != "sugar"))
                {
                    command = Console.ReadLine();
                    
                }
                if (true)
                {

                }
                {
                    counter++;

                    Console.WriteLine($"Baking batch number {counter}...");

                }

                //counter++;

                else
                {

                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
                //else
                //{
                //    Console.WriteLine($"Baking batch number {counter}...");
                //}



            }




        }
    }
}
