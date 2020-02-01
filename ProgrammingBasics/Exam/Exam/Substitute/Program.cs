using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int counter = 0;

            
                
                for (int a = K; a <= 8; a++)
                {
                    for (int b = 9; b >= L; b--)
                    {
                         for (int c = M; c <= 8; c++)
                         {
                                for (int d = 9; d >= N; d--)
                                {
                                    if (K % 2 == 0 && L % 2 != 0 && M % 2 == 0 && N % 2 != 0)
                                    {
                                        if (K == M || L == N)
                                        {
                                        Console.WriteLine("Cannot change the same player.");
                                        }
                                        else
                                        {
                                        Console.WriteLine($"{K}{L} - {M}{N}");
                                        counter++;
                                        }
                                         if (counter==6)
                                         {
                                             return;
                                         }
                                    }
                                    else
                                    {
                                        continue;
                                    }       
                                    
                                }
                                
                                  
                                
                         }
                    }
                }
            
        }
    }
}
