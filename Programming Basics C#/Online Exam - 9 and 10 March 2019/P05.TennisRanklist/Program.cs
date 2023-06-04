using System;

namespace P05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTournament = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());
            int totalPoint = startPoint;
            int point = 0;
            int countWin = 0;

            for (int i = 1; i <= countTournament; i++)
            {
                string stage = Console.ReadLine();

                if (stage=="W")
                {
                    totalPoint += 2000;
                    point += 2000;
                    countWin++;
                }
                else if (stage=="F")
                {
                    totalPoint += 1200;
                    point += 1200;
                }
                else if (stage=="SF")
                {
                    totalPoint += 720;
                    point += 720;
                }

            }

            double average = (point / countTournament);

            Console.WriteLine($"Final points: {totalPoint}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{((double)countWin/countTournament*100):f2}%");

        }
    }
}
