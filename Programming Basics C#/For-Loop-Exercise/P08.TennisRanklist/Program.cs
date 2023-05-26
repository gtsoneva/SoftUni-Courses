using System;

namespace P08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTournament = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());


            double sumW = 0;
            double sumF = 0;
            double sumSF = 0;
            double numW = 0;

            for (int i =1; i<=numTournament; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                   sumW+=2000;

                    numW++;
                }
                else if (stage == "F")
                {
                    sumF+=1200;
                }
                else
                {
                    sumSF+=720;
                }


            }
            double prWins = numW /numTournament * 100;
            double sumFromTour = sumW + sumF + sumSF;
            double totalPoints = sumW + sumF + sumSF + startingPoints;
            double pointAverage = Math.Floor(sumFromTour / numTournament);

            Console.WriteLine($"Final points: { totalPoints}");
            Console.WriteLine($"Average points: {pointAverage}");
            Console.WriteLine($"{prWins:f2}%");

        }
    }
}
