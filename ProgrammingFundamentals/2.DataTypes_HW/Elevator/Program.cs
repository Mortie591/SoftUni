using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int result = 0;
            if (numberOfPeople%elevatorCapacity==0)
            {
                result = numberOfPeople / elevatorCapacity;
            }
            else
            {
                result = numberOfPeople / elevatorCapacity + 1;

            }
            Console.WriteLine(result);
        }
    }
}
