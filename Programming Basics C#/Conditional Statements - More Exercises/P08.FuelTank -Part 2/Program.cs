using System;

namespace P08.FuelTank__Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"

            string typeFuel = Console.ReadLine();

            //•	Количество гориво – реално число в интервала[1.00 … 50.00]

            double quantityFuel = double.Parse(Console.ReadLine());

            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"

            string clubCard = Console.ReadLine();
          
            double finalPrice = 0;
            double price = 0;
            if (typeFuel == "Gasoline")
            {
                price = quantityFuel * 2.22;
                if (clubCard == "Yes")
                {
                    price = quantityFuel * (2.22 - 0.18);
                }


            }




            if (typeFuel == "Gas")
            {
                price = quantityFuel * 0.93;
                if (clubCard == "Yes")
                {
                    price = quantityFuel * (0.93 - 0.08);
                }

            }


            if (typeFuel == "Diesel")
            {
                price = quantityFuel * 2.33;
                if (clubCard == "Yes")
                {
                    price = quantityFuel * (2.33 - 0.12);
                }

            }
            if (quantityFuel > 20 && quantityFuel <= 25)
            {
                finalPrice = price - price * 0.08;

            }
            else if (quantityFuel > 25)
            {
                finalPrice = price - price * 0.1;
            }
            else
            {
                finalPrice = price;
            }


            Console.WriteLine($"{ finalPrice:f2} lv.");


        }
    }
}
