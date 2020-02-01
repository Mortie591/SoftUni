using System;

namespace Char_Int_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Monika";
             int sum = 0;
            //for (int index = 0; index < name.Length; index++)
                //{
                //    char currentLetter = name[index];
                //    sum += currentLetter;
                //    Console.WriteLine(currentLetter);
                //    Console.WriteLine((int)currentLetter);
                //}
                //Console.WriteLine(sum);
                string randomNumbers = "123456";
                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    int letter =int.Parse( randomNumbers[i].ToString());
                sum += letter;
                    Console.Write(letter);
                }
                Console.WriteLine(sum);
        }
    }
}
