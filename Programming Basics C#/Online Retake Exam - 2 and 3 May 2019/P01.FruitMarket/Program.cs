using System;

namespace P01.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberries = double.Parse(Console.ReadLine());
            double quantityBanana = double.Parse(Console.ReadLine());
            double quantityOrange = double.Parse(Console.ReadLine());
            double quantityRaspberries = double.Parse(Console.ReadLine());
            double quantityStrawberries = double.Parse(Console.ReadLine());


            double priceRaspberries = (strawberries / 2);
            double priceOrange=quantityOrange *( priceRaspberries- (priceRaspberries*0.4));
            double priceBanana= quantityBanana * (priceRaspberries- (priceRaspberries*0.8));
            double priceStrawberries = quantityStrawberries * strawberries;

            double totalPrice = (priceRaspberries* quantityRaspberries) + priceStrawberries + priceOrange + priceBanana;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
