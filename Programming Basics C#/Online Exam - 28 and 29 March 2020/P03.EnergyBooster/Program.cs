using System;

namespace P03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int quantitySet = int.Parse(Console.ReadLine());
            double price = 0;

            if (fruit=="Watermelon")
            {
                if (size=="small")
                {
                    price = (2 * 56) * quantitySet;
                }
                else
                {
                    price = (5 * 28.70) * quantitySet;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price = (2 * 36.66) * quantitySet;
                }
                else
                {
                    price = (5 * 19.60) * quantitySet;
                }
            }
           else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = (2 * 42.10) * quantitySet;
                }
                else
                {
                    price = (5 * 24.80) * quantitySet;
                }
            }
           else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = (2 * 20) * quantitySet;
                }
                else
                {
                    price = (5 * 15.20) * quantitySet;
                }
            }

            if (price>=400 && price<=1000)
             {
                price -= price * 0.15;
             }
            else if (price>1000)
            {
                price -= price / 2;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
