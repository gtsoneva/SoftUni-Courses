using System;

namespace P06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysTournament = int.Parse(Console.ReadLine());

           

            int dayWin = 0;
            int dayLose = 0;
            double allProfit = 0;

            for (int i = 1; i <= daysTournament; i++)
            {


                int countWin = 0;
                int countLost = 0;
                double dayProfit = 0;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Finish")
                    {

                        break;
                    }
                    string result = Console.ReadLine();


                    if (result == "win")
                    {

                        countWin++;
                        dayProfit += 20;

                    }
                    else if (result == "lose")
                    {

                        countLost++;

                    }
                }
                    if (countWin > countLost)
                    {
                        dayProfit *= 1.1;
                        dayWin++;
                    }
                    else
                    {
                        dayLose++;
                    }
                

                    allProfit += dayProfit;
              
            }
               if (dayWin>dayLose)
                {
                    allProfit *= 1.2;
                    Console.WriteLine($"You won the tournament! Total raised money: {allProfit:f2}");
                }
            
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allProfit:f2}");
            }

        }
    }
}
