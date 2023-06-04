using System;

namespace P02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            double guest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double countEasterBread = Math.Ceiling(guest / 3);
            double countEggs = guest * 2;
            double eaasterBread = countEasterBread * 4;
            double eggs = countEggs * 0.45;
            double totalPrice = eaasterBread + eggs;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Lyubo bought {countEasterBread} Easter bread and {countEggs} eggs.");
                Console.WriteLine($"He has {budget - totalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice - budget:f2} lv. more.");
            }



        }
    }
}
