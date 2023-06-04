using System;

namespace P03.LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int x = 1; x <= 9; x++)
                        {
                            if ((i + k) == (j + x) && n % (i + k) == 0)

                            {
                                Console.Write($"{i}{k}{j}{x} ");
                            }

                        }
                    }
                }
        }
            }
    }
}

