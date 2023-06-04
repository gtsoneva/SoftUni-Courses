using System;

namespace P04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEggsFirstPlayer = int.Parse(Console.ReadLine());
            int countEggsSecondPlayer = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input!="End")
            {
                if (input=="one")
                {
                    countEggsSecondPlayer -= 1;
                }
                else if (input=="two")
                {
                    countEggsFirstPlayer -= 1;
                }
                if (input=="End")
                {
                    break;
                }

                if (countEggsFirstPlayer<=0 || countEggsSecondPlayer<=0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (countEggsFirstPlayer <= 0 )
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {countEggsSecondPlayer} eggs left.");
            }
            if(countEggsSecondPlayer<=0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {countEggsFirstPlayer} eggs left.");
            }
            if (input == "End")
            {
                Console.WriteLine($"Player one has {countEggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {countEggsSecondPlayer} eggs left.");
            }
        }
    }
}
