using System;

namespace P05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int movesInGame = int.Parse(Console.ReadLine());

            double result = 0;
            double num0to9 = 0;
            double num10to19 = 0;
            double num20to29 = 0;
            double num30to39 = 0;
            double num40to50 = 0;
            double invalidNum = 0;



            for (int i = 1; i <= movesInGame; i++)
            {
                int numInGame = int.Parse(Console.ReadLine());

                if (numInGame < 0 || numInGame > 50)
                {
                    result = result / 2;
                    invalidNum++;
                }

                else if (numInGame <= 9)
                {
                    result = result + numInGame * 0.2;
                    num0to9++;
                }
                else if (numInGame <= 19)
                {
                    result = result + numInGame * 0.3;
                    num10to19++;
                }
                else if (numInGame <= 29)
                {
                    result = result + numInGame * 0.4;
                    num20to29++;
                }
                else if (numInGame <= 39)
                {
                    result = result + 50;
                    num30to39++;
                }
                else
                {
                    result = result + 100;
                    num40to50++;
                }
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(num0to9/movesInGame)*100:f2}%");
            Console.WriteLine($"From 10 to 19: {(num10to19/movesInGame)*100:f2}%");
            Console.WriteLine($"From 20 to 29: {(num20to29/movesInGame)*100:f2}%");
            Console.WriteLine($"From 30 to 39: {(num30to39/movesInGame)*100:f2}%");
            Console.WriteLine($"From 40 to 50: {(num40to50/movesInGame)*100:f2}%");
            Console.WriteLine($"Invalid numbers: {(invalidNum/movesInGame)*100:f2}%");
         

        }
    }
}
