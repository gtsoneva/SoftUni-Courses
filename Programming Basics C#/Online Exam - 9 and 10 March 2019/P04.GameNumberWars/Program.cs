using System;

namespace P04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirstPlayer = Console.ReadLine();
            string nameSecondPlayer = Console.ReadLine();



            string input = Console.ReadLine();

            
            int totalPointFirst = 0;
            int totalPointSecond = 0;

            while (input!="End of game")
            {
                int cardFirstPlayer = int.Parse(input);
                int cardSecondPlayer = int.Parse(Console.ReadLine());

                int pointFirstPlayer = 0;
                int pointSecondPlayer = 0;

                if (cardFirstPlayer>cardSecondPlayer)
                {
                    pointFirstPlayer = cardFirstPlayer - cardSecondPlayer;
                    totalPointFirst += pointFirstPlayer;
                }
                else if (cardFirstPlayer== cardSecondPlayer)
                {
                    Console.WriteLine("Number wars!");
                    cardFirstPlayer = int.Parse(Console.ReadLine());
                    cardSecondPlayer = int.Parse(Console.ReadLine());
                    
                    if (cardFirstPlayer>cardSecondPlayer)
                    {
                        Console.WriteLine($"{ nameFirstPlayer} is winner with { totalPointFirst} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{ nameSecondPlayer} is winner with { totalPointSecond} points");
                        break;
                    }

                }
                else if(cardSecondPlayer>cardFirstPlayer)
                {
                    pointSecondPlayer = cardSecondPlayer-cardFirstPlayer;
                    totalPointSecond += pointSecondPlayer;
                }
                if (input=="End of game")
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End of game")
            {
                Console.WriteLine($"{ nameFirstPlayer} has {totalPointFirst} points");
                Console.WriteLine($"{nameSecondPlayer} has {totalPointSecond} points");
            }

        }
    }
}
