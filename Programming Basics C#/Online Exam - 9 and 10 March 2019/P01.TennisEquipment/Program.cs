using System;

namespace P01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRacket = double.Parse(Console.ReadLine());
            int quantityTennisRacket = int.Parse(Console.ReadLine());
            int pairSneakers = int.Parse(Console.ReadLine());

            double priceTennisRacket = tennisRacket * quantityTennisRacket;
            double priceSneakers = (tennisRacket / 6) * pairSneakers;
            double equipment = (priceTennisRacket + priceSneakers) * 0.2;

            double totalPrice = priceSneakers + priceTennisRacket + equipment;
            double priceForDjokovich = totalPrice / 8;
            double priceSponsor = totalPrice * 7 / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceForDjokovich)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSponsor)}");
        }
    }
}
