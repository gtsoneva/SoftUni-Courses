using System;

namespace P06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int charLetter = 0;
            int maxScore = 0;
            string WinnerName = string.Empty;
            while (name!="Stop")
            {
                int currentScore = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    charLetter = (int)name[i];
                    int currentNum = int.Parse(Console.ReadLine());
                    if (charLetter==currentNum)
                    {
                        currentScore = currentScore + 10;
                    }
                    else
                    {
                        currentScore = currentScore + 2;
                    }
                    if (currentScore>=maxScore)
                    {
                        maxScore = currentScore;
                        WinnerName = name;
                    }
                    
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {WinnerName} with {maxScore} points!");
        }
    }
}
