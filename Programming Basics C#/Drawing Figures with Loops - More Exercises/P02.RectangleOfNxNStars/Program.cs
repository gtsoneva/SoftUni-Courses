using System;

namespace P01.RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
