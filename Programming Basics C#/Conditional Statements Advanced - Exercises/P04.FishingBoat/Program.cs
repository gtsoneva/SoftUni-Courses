using System;

namespace P04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishermen = int.Parse(Console.ReadLine());
            double rent = 0;
            double discount = 0;
            double totalSum = 0;
            if (season=="Spring")
            {
                rent = 3000;
                if (numFishermen <= 6)
                {
                    rent = rent - rent * 0.1;
                }
                else if (numFishermen>=7 && numFishermen <=11)
                {
                    rent = rent - rent * 0.15;
                }
                else if (numFishermen>12)
                {
                    rent = rent - rent * 0.25;
                }
                if (numFishermen % 2==0)
                {
                    discount = 0.05;
                }
                else
                {
                    discount = 0;
                }

            }

            if (season == "Summer" || season== "Autumn")
            {
                rent = 4200;
                if (numFishermen <= 6)
                {
                    rent = rent - rent * 0.1;
                }
                else if (numFishermen >= 7 && numFishermen <= 11)
                {
                    rent = rent - rent * 0.15;
                }
                else if (numFishermen > 12)
                {
                    rent = rent - rent * 0.25;
                }
                if (numFishermen % 2 == 0 && season=="Summer")
                {
                    discount = 0.05;
                }
                else
                {
                    discount = 0;
                }

            }

            if (season == "Winter")
            {
                rent = 2600;
                if (numFishermen <= 6)
                {
                    rent = rent - rent * 0.1;
                }
                else if (numFishermen >= 7 && numFishermen <= 11)
                {
                    rent = rent - rent * 0.15;
                }
                else if (numFishermen > 12)
                {
                    rent = rent - rent * 0.25;
                }
                if (numFishermen % 2 == 0)
                {
                    discount = 0.05;
                }
                else
                {
                    discount = 0;
                }

            }

            totalSum = rent - rent * discount;

            if (totalSum<=budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalSum:F2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum-budget:f2} leva.");
            }
        }
    }
}
