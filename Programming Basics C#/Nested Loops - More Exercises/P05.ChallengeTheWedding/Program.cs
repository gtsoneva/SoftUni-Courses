using System;

namespace P05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMen = int.Parse(Console.ReadLine());
            int numWomen = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());
            int count = 0;
         

            for (int i = 1; i <= numMen; i++)
            {
                for (int k = 1; k <= numWomen; k++)
                {
                    count++;
                    Console.Write($"({i} <-> {k}) ");
                    if (count==maxTables)
                    {
                        break;

                    }
                }
                if (count==maxTables)
                {
                    break;
                }

            }
        }
    }
}
