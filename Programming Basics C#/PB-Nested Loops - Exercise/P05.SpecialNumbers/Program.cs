using System;

namespace P05.SpecialNumbers
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
                            if (n % i == 0 && 
                                n % k == 0 &&
                                n % j == 0 && 
                                n % x == 0)

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
