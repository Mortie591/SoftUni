using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int diff = 0;
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                
                if (number >= max)
                {
                    max = number;
                }

                 sum+= number;
                
            }
            diff = Math.Abs(sum - 2*max);

            //sum += number - max;
            // Console.WriteLine(max);
             // Console.WriteLine(sum);
            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum-max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");

            }
        }
          
    }
}
