using System;

namespace P01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int CountSeason = int.Parse(Console.ReadLine());
            int CountEpizod = int.Parse(Console.ReadLine());
            double timeEpisodeWithoutCommercials = double.Parse(Console.ReadLine());

            double commercials = 0.2 * timeEpisodeWithoutCommercials;
            double epizodWithCommercials = timeEpisodeWithoutCommercials + commercials;
            double additionallyTime = CountSeason * 10;
            double totalTime = epizodWithCommercials * CountEpizod * CountSeason + additionallyTime;




            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
