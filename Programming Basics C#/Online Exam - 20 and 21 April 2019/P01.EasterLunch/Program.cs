using System;

namespace P01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEasterBread = int.Parse(Console.ReadLine());
            int countEggs = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double priceEasterBread = countEasterBread * 3.2;
            double priceEggs = countEggs * 4.35;
            double paintForEggs = (countEggs * 12) * 0.15;
            double priceCookies = cookiesKg * 5.40;

            double totalPrice = priceEasterBread + priceEggs + paintForEggs + priceCookies;

            Console.WriteLine($"{totalPrice:f2}");       
        }
    }
}
