using System;

namespace P05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTeam = Console.ReadLine();
            int numAllGames = int.Parse(Console.ReadLine());
            int countW = 0;
            int countD = 0;
            int countL = 0;
            int pointW = 0;
            int pointD = 0;
            int pointL = 0;

            if(numAllGames<=0)
            {
                Console.WriteLine($"{nameTeam} hasn't played any games during this season.");
            }
            for (int i = 1; i <=numAllGames; i++)
            {
                char resultGame = char.Parse(Console.ReadLine());
                
                if (resultGame== 'W')
                {
                     countW++;
                    
                }
                else if (resultGame=='D')
                {
                    countD++;
                }
                else
                {
                    countL++;
                }
               
            }
            pointW = countW * 3;
            pointD = countD * 1;
            pointL = countD * 0;
            double totalPoints = pointW + pointD;
            if (numAllGames > 0)
            {
                Console.WriteLine($"{nameTeam} has won {totalPoints} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {countW}");
                Console.WriteLine($"## D: {countD}");
                Console.WriteLine($"## L: {countL}");
                Console.WriteLine($"Win rate: {(double)countW / numAllGames * 100:f2}%");
            }
        }
    }
}
