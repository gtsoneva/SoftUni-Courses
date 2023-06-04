using System;

namespace P05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFilm = int.Parse(Console.ReadLine());


            string nameFilm;
            string movieMaxRating=string.Empty;
            string movieMinRating=string.Empty;
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double ratingAll = 0;

            for (int i = 1; i <= countFilm; i++)
            {
               nameFilm = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating>maxRating)
                {
                    maxRating = rating;
                    movieMaxRating = nameFilm;
                }
                if (rating<minRating)
                {
                    minRating = rating;
                    movieMinRating = nameFilm;
                }
                
                ratingAll += rating;
            }

            Console.WriteLine($"{movieMaxRating} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{movieMinRating} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {(ratingAll/countFilm):f1}");
        }
    }
}
