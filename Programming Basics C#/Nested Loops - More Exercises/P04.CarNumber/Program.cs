using System;

namespace P04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                for (int k = start; k <= stop; k++)
                {
                    for (int j = start; j <= stop; j++)
                    {
                        for (int x = start; x <= stop; x++)
                        {
                            if (i > x)
                            {
                                if (i % 2 == 0)

                                {
                                    if (x % 2 != 0)
                                    {
                                        if ((i - x) % 2 != 0 && (k + j) % 2 == 0)
                                        {
                                            Console.Write($"{i}{k}{j}{x} ");
                                        }
                                    }
                                }

                                else
                                {
                                    if (x % 2 == 0)
                                    {
                                        if (i % 2 != 0)
                                        {
                                            if ((i - x) % 2 != 0 && (k + j) % 2 == 0)
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
            }
        }
    }
}
