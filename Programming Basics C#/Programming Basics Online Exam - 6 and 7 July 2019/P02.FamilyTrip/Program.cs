using System;

namespace P02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
          double night = double.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            double procentCosts = double.Parse(Console.ReadLine());

            
            if (night>7)
            {
                priceNight = priceNight -priceNight*0.05;
            }
            double totalPriceNight = priceNight * night;
            double costs= (budget * (procentCosts/100));

            double costsTotal = totalPriceNight + costs;
            if (costsTotal<=budget)
            {
                Console.WriteLine($"Ivanovi will be left with {Math.Abs(costsTotal - budget):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(costsTotal-budget):f2} leva needed.");
 
            }
        }
    }
}
