using System;

namespace P02.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double priceClothersForOneExtras = double.Parse(Console.ReadLine());


            double priceDecor = budget * 0.10;

            double priceForClothers = extrasCount * priceClothersForOneExtras;

            if (extrasCount>150)
            {
                priceForClothers -= priceForClothers * 0.10;
            }
            double totalPrice = priceDecor + priceForClothers;

            if (budget<totalPrice)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(totalPrice - budget):f2} leva more.");
            }
            else
            {
               

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budget - totalPrice):f2} leva left.");
            }
        }
    }
}
