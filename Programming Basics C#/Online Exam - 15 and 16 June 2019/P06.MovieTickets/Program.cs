using System;

namespace P06.MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
           int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int a = a1; a <= a2 - 1; a++)
            {
                char letter = (char)a;


                for (int b = 1; b <= n - 1; b++)
                {


                    for (int c = 1; c <= (n / 2 - 1); c++)
                    {
                        if (a % 2 == 1 && (b + c + a) % 2 == 1)
                        {
                            Console.WriteLine($"{letter}-{b}{c}{a}");
                        }                       
                    }
                }
            }


        }
    }
}




