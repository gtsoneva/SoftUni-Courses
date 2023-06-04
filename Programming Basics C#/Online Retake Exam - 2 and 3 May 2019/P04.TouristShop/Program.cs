using System;

namespace P04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());


            string input = Console.ReadLine();
            double totalPrice = 0;
            int countProduct = 0;
            double product = 0;

            while (input != "Stop")
            {
                double priceProduct = double.Parse(Console.ReadLine());
                countProduct++;

                if (countProduct  %3==0)
                {
                    priceProduct = priceProduct / 2;

                }
                

                if (priceProduct>budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {priceProduct-budget:f2} leva!");
                    break;
                }
                if (input == "Stop")
                {

                    break;
                }

                budget -= priceProduct;
                totalPrice += priceProduct;
                input = Console.ReadLine();
            }
           
            if (input == "Stop")
            {
                Console.WriteLine($"You bought {countProduct} products for {totalPrice:f2} leva.");

            }

        }

    }
}
