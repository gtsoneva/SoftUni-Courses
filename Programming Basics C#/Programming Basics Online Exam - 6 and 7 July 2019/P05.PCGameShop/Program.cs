using System;

namespace P05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGames = int.Parse(Console.ReadLine());
            int countHearthstone = 0;
            int countFornite = 0;
            int countOverwatch = 0;
            int countOthers = 0;
            for (int i = 1; i <=numGames; i++)
            {
                string nameGame = Console.ReadLine();
                if (nameGame== "Hearthstone")
                {
                    countHearthstone++;
                }
                else if (nameGame== "Fornite")
                {
                    countFornite++;
                }
                else if (nameGame== "Overwatch")
                {
                    countOverwatch++;
                }
                else
                {
                    countOthers++;
                }
            }
            Console.WriteLine($"Hearthstone - {(double)countHearthstone / numGames * 100:F2}%");
            Console.WriteLine($"Fornite - {(double)countFornite / numGames * 100:F2}%");
            Console.WriteLine($"Overwatch - {(double)countOverwatch / numGames * 100:F2}%");
            Console.WriteLine($"Others - {(double)countOthers / numGames * 100:F2}%");


        }
    }
}
