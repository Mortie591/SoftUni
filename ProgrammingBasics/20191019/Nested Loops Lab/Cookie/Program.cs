using System;

namespace Cookie
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchesCount = int.Parse(Console.ReadLine());
            string ingredient = "";

            for (int i = 1; i <= batchesCount; i++)
            {
                bool containsEggs = false;
                bool containsFlour = false;
                bool containsSugar = false;
                while (true)
                {
                    ingredient = Console.ReadLine();

                    if (ingredient == "eggs")
                    {
                        containsEggs = true;
                        continue;
                    }
                    else if (ingredient == "flour")
                    {
                        containsFlour = true;
                        continue;
                    }
                    else if (ingredient == "sugar")
                    {
                        containsSugar = true;
                        continue;
                    }
                    else if (ingredient == "Bake!")
                    {
                        if (containsEggs == true && containsFlour == true && containsSugar == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                }
            }
        }
    }
}
