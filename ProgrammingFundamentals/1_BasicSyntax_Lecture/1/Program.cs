using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicOperations:
            //Console.WriteLine("What's your name?");
            //string pesho = Console.ReadLine();
            //Console.WriteLine($"Hello, {pesho}");
            //Console.WriteLine("What's your age?");
            //int age = int.Parse(Console.ReadLine());
            //GoToNewLine!!!!
            //Console.WriteLine($"The name is {pesho}\nThe age is: {age}");

            //if operator:
            //Console.WriteLine("What is your grade?");
            //double grade = double.Parse(Console.ReadLine());
            //Console.WriteLine("Will you graduate?");
            //if (grade>3)
            //{
            //    Console.WriteLine("Evala!");
            //}
            //else
            //{
            //    Console.WriteLine("Next time ;)");
            //}



            //int input = int.Parse(Console.ReadLine());

            //switch (input)
            //{
            //    case 1:
            //        Console.WriteLine("Looser! *_*");
            //        break;
            //    case 5:
            //        Console.WriteLine("Topa, brat! ^_^");
            //        break;
            //    default:
            //        break;
            //}

            //RandomOperator '?'
            //bool isMale = true;
            //int muscles = isMale ? 100 : 20;
            //Console.WriteLine(muscles);

            //Loops:


            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <n; i++)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // for Tab+Tab returns a reverse loop;

            //int n = int.Parse(Console.ReadLine());
            //int sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum *= i;
            //}
            //Console.WriteLine(sum);

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i}*{j}={i*j}, ");
            //    }
            //    Console.WriteLine();
            // }

            //While Loop:

            //int n = int.Parse(Console.ReadLine());
            //int times = 0;

            //while (n%10 != 1)
            //{
            //    times++;
            //    n = n / 10;
            //}
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(n);
        }

    }
}
