using System;

namespace P02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minControla = int.Parse(Console.ReadLine());
            int sekControla = int.Parse(Console.ReadLine());
            double lengthChuteInMeters = double.Parse(Console.ReadLine());
            int meter100InSek = int.Parse(Console.ReadLine());

            double reducedTime = (lengthChuteInMeters / 120) *2.5;

            double controla = (minControla * 60) + sekControla;

            double timeMarin = (lengthChuteInMeters / 100) * meter100InSek - reducedTime;

            if (controla >= timeMarin)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {timeMarin-controla:f3} second slower.");
            }
        }
    }
}
