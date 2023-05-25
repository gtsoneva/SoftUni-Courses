using System;

namespace P03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            if (typeFlower == "Roses")
            {
                price = 5.00;
                if (numFlowers > 80)
                {
                    price = price - price * 0.10;
                }
            }

            if(typeFlower == "Dahlias")
            {
                price = 3.80;
                if (numFlowers > 90)
                {
                    price = price- price * 0.15;
                }
            }

            if (typeFlower == "Tulips")
            {
                price = 2.80;
                if (numFlowers > 80)
                {
                    price = price - price * 0.15;
                }
            }


            if (typeFlower == "Narcissus")
            {
                price = 3.00;
                if (numFlowers<120)
                {
                    price = price+ price * 0.15;
                }
            }


            if (typeFlower == "Gladiolus")
            {
                price = 2.50;
                if (numFlowers < 80)
                {
                    price = price + price * 0.20;
                }
            }
            
           double totalSum = numFlowers * price;

            if (totalSum<= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with { numFlowers } { typeFlower} and {Math.Abs(totalSum - budget):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need { Math.Abs(budget - totalSum):f2} leva more.");
            }
        }
    }
}
