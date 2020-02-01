using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int k = 0;
            double payment = 0;
            double balance = 0;
            while (k<=n)
            {
                k++;
                payment=double.Parse(Console.ReadLine());

                if (payment <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {balance:f2}");
                    break;
                }
                Console.WriteLine($"Increase: {payment:f2}");
                balance += payment;

                if (k == n)
                {
                    Console.WriteLine($"Total: {balance:f2}");
                    break;
                }
            }
        }
    }
}
