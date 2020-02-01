using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string typeOfKeg = null;
            string maxVolumeKeg = null;

            double currentVolume = double.MinValue;
            double maxVolume = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                typeOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                currentVolume = Math.PI * radius * radius * height;

                if (currentVolume>maxVolume)
                {
                    maxVolume = currentVolume;
                    maxVolumeKeg = typeOfKeg;
                }

            }
            Console.WriteLine(maxVolumeKeg);
        }
    }
}
