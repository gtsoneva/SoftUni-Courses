using System;

namespace P10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinsOne = int.Parse(Console.ReadLine());
            int coinsTwo = int.Parse(Console.ReadLine());
            int coinsFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int one = 0; one <= coinsOne; one++)
            {
                for (int two = 0; two <= coinsTwo; two++)
                {
                    for (int five = 0; five <= coinsFive; five++)
                    {
                        if (one * 1 + two * 2 + five * 5 == sum)
                        {
                            Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }

        }
  }
}
