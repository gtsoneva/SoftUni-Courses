using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightPacetKg = double.Parse(Console.ReadLine());
            string typeService = Console.ReadLine();
            int distanceKm = int.Parse(Console.ReadLine());
            double priceKm = 0;
            double price = 0;
            double priceMarkUp = 0;
            double totalSum = 0;

   

            if (typeService=="standard")
            {
                if (weightPacetKg<1)
                {
                    priceKm = 0.03;
                }
                else if (weightPacetKg>=1 && weightPacetKg<10)
                {
                    priceKm = 0.05;
                }
                else if (weightPacetKg>=10 && weightPacetKg<=40)
                {
                    priceKm = 0.10;
                }
                else if (weightPacetKg>40 && weightPacetKg<=90)
                {
                    priceKm = 0.15;
                }
                else if (weightPacetKg>90 && weightPacetKg<=150)
                {
                    priceKm = 0.20;
                }
                totalSum = distanceKm * priceKm;
                
            }
            else if (typeService=="express")
            {
                if (weightPacetKg < 1)
                {
                    
                    price = 0.03;
                    priceMarkUp = price * 0.8;
  

                }
                else if (weightPacetKg >= 1 && weightPacetKg < 10)
                {
                    price = 0.05;
                    priceMarkUp = price * 0.4;

                }
                else if (weightPacetKg >= 10 && weightPacetKg <= 40)
                {

                    price = 0.10;
                    priceMarkUp = price * 0.05;

                }
                else if (weightPacetKg > 40 && weightPacetKg <= 90)
                {
                    price = 0.15;
                    priceMarkUp = price * 0.02;

                }
                else if (weightPacetKg > 90 && weightPacetKg <= 150)
                {
                    price = 0.20;
                    priceMarkUp = price * 0.01;

                }
                double totalMarkUpKm = weightPacetKg * priceMarkUp;
                double totalMarkUp = distanceKm * totalMarkUpKm;
                totalSum = (distanceKm * price) + totalMarkUp;
               
            }

            Console.WriteLine($"The delivery of your shipment with weight of {weightPacetKg:f3} kg. would cost {totalSum:f2} lv.");

        }
    }
}
