using System;

namespace P02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSek = double.Parse(Console.ReadLine());
            double distanceInMin = double.Parse(Console.ReadLine());
            double timeInSekFor1meter = double.Parse(Console.ReadLine());

            double timeInSek = distanceInMin * timeInSekFor1meter;
            double delay = Math.Floor(distanceInMin / 50) * 30;
            double totalTime = timeInSek + delay;

            if (totalTime<recordInSek)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-recordInSek:f2} seconds slower.");
            }
        }
    }
}
