using System;

namespace P04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            string carType = string.Empty;
            string carClass = string.Empty;
            double priceCar = 0;
            if (budget<=100)
            {
                carClass = "Economy class";

                if (season=="Summer")
                {
                    carType = "Cabrio";
                    priceCar = budget * 0.35;
                }
                else
                {
                    carType = "Jeep";
                        priceCar = budget * 0.65;

                }
            }

            else if (budget>100 && budget<=500)
            {
                carClass = "Compact class";

                if (season=="Summer")
                {
                    carType = "Cabrio";
                    priceCar = budget * 0.45;
                }
                else
                {
                    carType = "Jeep";
                    priceCar = budget * 0.80;
                }
            }

            else
            {
                carClass = "Luxury class";
                 carType = "Jeep";
                    priceCar = budget * 0.90;
                
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {priceCar:f2}");
        }
    }
}
