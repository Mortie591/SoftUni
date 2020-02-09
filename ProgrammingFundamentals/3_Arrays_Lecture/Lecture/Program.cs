using System;
using System.Linq;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize an array
            //int[] ages = new int[3];
            //ages[0] = 15;
            //ages[1] = 55;
            //ages[2] = 3;
            //Console.WriteLine(ages.Length);
            //Console.WriteLine(ages[2]);
            //Console.WriteLine("Please enter array length:");
            //int n =int.Parse(Console.ReadLine());
            //int[] ages=new int[n];
            //int counter = 0;

            //for (int i = 0; i <ages.Length; i++)
            //{
            //    counter += 5;
            //    ages[i] =counter;
            //    Console.WriteLine($"Array[{i}]={ages[i]}");
            //}

            //Console.WriteLine($"The array length is {ages.Length}");

            // Array of strings:Example

            //string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //Console.WriteLine("Please enter a number from 1-7:");
            //int day = int.Parse(Console.ReadLine());
            //if (day>=1 && day<=7)
            //{
            //    Console.WriteLine(daysOfWeek[day-1]);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number!");
            //}

            //Reading array from the console: Example

            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] array = new int[arrayLength];

            //for (int i = 0; i <= arrayLength; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The {i + 1} is: {array[i]}");
            //}

            //Enter n numbers multiplied by 5:

            //Console.WriteLine("Enter array length:");
            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] array = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine()) * 5;
            //}
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.WriteLine(array[i]);

            //}

            //Example of using Split:

            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            //string[] words = text.Split();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine($"Array [{i}]={words[i]}");
            //}

            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            //string[] separator = {" ","|","," };
            //string[] words = text.Split(separator,StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine($"Array [{i}]={words[i]}");
            //}

            //Example- convert string into number:
            //string input = Console.ReadLine();
            //string[] numbersAsStrings = input.Split();
            //int[] numersAsIntegers = new int[numbersAsStrings.Length];
            //for (int i = 0; i < numersAsIntegers.Length; i++)
            //{
            //    numersAsIntegers[i] = int.Parse(numbersAsStrings[i]);
            //}
            //for (int i = 0; i < numersAsIntegers.Length; i++)
            //{
            //    Console.WriteLine($"Array [{i}]={numersAsIntegers[i]+5}");
            //    Console.WriteLine($"Array [{i}]={numbersAsStrings[i] + 5}");

            //}

            //Example- convert string srray into int array via Select:

            //var inputLine = Console.ReadLine();
            //int[] arr = inputLine.Split().Select(int.Parse).ToArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Array [{i}]={arr[i] + 5}");
            //}
            //double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"Array [{i}]={numbers[i]}");
            //}

            //Example of String.Join:


            //int[] ages = { 1, 2, 3 };
            //string array = string.Join("\n", ages);
            //Console.WriteLine(array);

            //Reverse array of strings:

            //string[] names = Console.ReadLine().Split();
            //for (int i = 0; i < names.Length/2; i++)
            //{
            //    string temp = names[i];
            //    names[i] = names[names.Length - i - 1];
            //    names[names.Length - i - 1] = temp;
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine(String.Join(", ",names));


            //For Each:

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int currentNumber in numbers)
            {
                Console.WriteLine(currentNumber);
            }







        }
    }
}
