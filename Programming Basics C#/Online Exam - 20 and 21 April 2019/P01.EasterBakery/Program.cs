using System;

namespace P01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFlourForKg = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
           
            int countEggs = int.Parse(Console.ReadLine());
            int countYeast = int.Parse(Console.ReadLine());

            double priceFlour = priceFlourForKg * kgFlour;
            double priceSugar = (priceFlourForKg * 0.75) * kgSugar;
            double priceEggs = (priceFlourForKg *1.1) * countEggs;
            double priceYeast = ((priceFlourForKg * 0.75) * 0.2) * countYeast;

            double totalPrice = priceFlour + priceSugar + priceYeast + priceEggs;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
