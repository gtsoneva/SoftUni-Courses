using System;

namespace P06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int coutTournamets = 0;
            int countWin = 0;
            int countLost = 0;

            while (input!="End of tournaments")
            {
                if (input=="End of tournaments")
                {
                    break;
                }
                int numTournaments = int.Parse(Console.ReadLine());
                int game = 0;

                for (int i = 1; i <= numTournaments; i++)
                {
                   
                    coutTournamets++;
                    int pointsFirstTeam = int.Parse(Console.ReadLine());
                    int pointsSecondTeam = int.Parse(Console.ReadLine());
                    
                    if (pointsFirstTeam>pointsSecondTeam)
                    {
                        countWin++;
                        game++;
                        Console.WriteLine($"Game {game} of tournament {input}: win with {pointsFirstTeam-pointsSecondTeam} points.");
                    }
                    else
                    {
                        countLost++;
                        game++;
                        Console.WriteLine($"Game {game} of tournament {input}: lost with {pointsSecondTeam-pointsFirstTeam} points.");
             
                    }

                         
                }

                input = Console.ReadLine();
            }
            if (input=="End of tournaments")
            {
                Console.WriteLine($"{((double)countWin/coutTournamets*100):f2}% matches win");
                Console.WriteLine($"{((double)countLost/coutTournamets*100):f2}% matches lost");
            }
        }
    }
}
