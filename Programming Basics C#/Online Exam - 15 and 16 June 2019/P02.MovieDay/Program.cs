using System;

namespace P02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeForPictures = double.Parse(Console.ReadLine());
            int countScene = int.Parse(Console.ReadLine());
            int timeForScene = int.Parse(Console.ReadLine());

            double preparation = timeForPictures * 0.15;
            double timeForAllScene = countScene * timeForScene;
            double necessaryTime = preparation + timeForAllScene;

            if (timeForPictures>necessaryTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(Math.Abs(necessaryTime-timeForPictures))} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Abs(timeForPictures-necessaryTime)} minutes.");
            }
        }
    }
}
