using System;

namespace P01_BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double priceSneakers = tax -( tax * 0.4);
            double priceEquipment = priceSneakers - (priceSneakers * 0.2);
            double priceBall = priceEquipment / 4;
            double priceAccsesory = priceBall / 5;

            double totalPrice = priceBall + priceEquipment + priceSneakers + tax + priceAccsesory ;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
