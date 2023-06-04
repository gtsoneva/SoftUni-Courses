using System;

namespace P05.DivisionWithout_emainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 1; i <=n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                 if ( currentNum %2==0)
                 {
                    countP1++;
                 }
                 if (currentNum%3==0)
                {
                    countP2++;
                }
                 if (currentNum% 4==0)
                {
                    countP3++;
                }

               
            }

            p1 = ((double)countP1 / n) * 100;
            p2 = ((double)countP2 / n) * 100;
            p3 = ((double)countP3 / n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
