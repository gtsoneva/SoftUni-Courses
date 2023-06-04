using System;

namespace P02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatch = Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();

            int win = 0;
            int lost = 0;
            int drawn = 0;


            char firstTeamToFirstMatch = firstMatch[0];
            char secondTeamToFirstMatch = firstMatch[2];
            char firstTeamToSecondMatch = secondMatch[0];
            char secondTeamToSecondMatch = secondMatch[2];
            char firstTeamToThirdMatch = thirdMatch[0];
            char secondTeamToThirdMatch = thirdMatch[2];

            if (firstTeamToFirstMatch>secondTeamToFirstMatch)
            {
                win++;
            }
            else if (firstTeamToFirstMatch==secondTeamToFirstMatch)
            {
                drawn++;
            }
            else
            {
                lost++;
            }

            if (firstTeamToSecondMatch > secondTeamToSecondMatch)
            {
                win++;
            }
            else if (firstTeamToSecondMatch == secondTeamToSecondMatch)
            {
                drawn++;
            }
            else
            {
                lost++;
            }

            if (firstTeamToThirdMatch>secondTeamToThirdMatch)
            {
                win++;
            }
            else if (firstTeamToThirdMatch==secondTeamToThirdMatch)
            {
                drawn++;
            }
            else
            {
                lost++;
            }


            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($" Drawn games: {drawn}");
        }
    }
}
