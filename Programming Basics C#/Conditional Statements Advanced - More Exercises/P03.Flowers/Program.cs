using System;

namespace P03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChrysanthemum = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();


            double priceChrysanthemum = 0;
            double priceRoses = 0;
            double priceTulips = 0;

            if (season == "Spring" || season == "Summer")
            {
                priceChrysanthemum = numChrysanthemum * 2;
                priceRoses = numRoses * 4.10;
                priceTulips = numTulips * 2.50;
            }
            else
            {
                priceChrysanthemum = numChrysanthemum * 3.75;
                priceRoses = numRoses * 4.50;
                priceTulips = numTulips * 4.15;
            }
                double sumBouquet = priceChrysanthemum + priceRoses + priceTulips;

                if (holidayOrNot== "Y")
                {
                    sumBouquet = sumBouquet + sumBouquet * 0.15;

                }

                if (season=="Spring" && numTulips > 7)
            {
                sumBouquet=sumBouquet-sumBouquet * 0.05;

            }
                else if(season=="Winter" && numRoses>=10)
            {
                sumBouquet=sumBouquet-sumBouquet * 0.10;
            }

            double numFlower = numRoses + numChrysanthemum + numTulips;
              if (numFlower> 20)
            {
                sumBouquet = sumBouquet - sumBouquet * 0.20;
                    
            }

            double totalSum = sumBouquet + 2;
            Console.WriteLine($"{totalSum:F2}");

        }
        
    }
}
