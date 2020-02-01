using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            char letter='\0';
            int max = int.MinValue;
            string winner = "";

            while (name!="STOP")
            {
                int sum = 0;
                string winnerName = "";

                for (int i = 0; i < name.Length; i++)
                {
                letter = name[i];
                sum += letter;
                winnerName += letter;
                }
               

                if (sum>max)
            {
                max = sum;
                    winner = winnerName;
            }
           
                name = Console.ReadLine();
                if (name=="STOP")
                {
                    break;
                }
                
            }
            
            Console.WriteLine($"Winner is {winner} - {max}!");

        }
    }
}
