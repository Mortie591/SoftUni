using System;

namespace Movie_Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMovies = int.Parse(Console.ReadLine());
            double minimumRating = double.MaxValue;
            double maximumRating = double.MinValue;
            string lowestRatingTitle = "";
            string highestRatingTitle = "";
            double sumOfRatings = 0;

            for (int currentMovie = 1; currentMovie <= numberOfMovies; currentMovie++)
            {
                string movieTitle = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());
                if (movieRating>=maximumRating)
                {
                    maximumRating = movieRating;
                    highestRatingTitle = movieTitle;
                }
                else if (movieRating <= minimumRating)
                {
                    minimumRating = movieRating;
                    lowestRatingTitle = movieTitle;
                }
                sumOfRatings += movieRating;

            }
            double averageRating = sumOfRatings / numberOfMovies;
            Console.WriteLine($"{highestRatingTitle} is with highest rating: {maximumRating:f1}");
            Console.WriteLine($"{lowestRatingTitle} is with lowest rating: {minimumRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
    
}
