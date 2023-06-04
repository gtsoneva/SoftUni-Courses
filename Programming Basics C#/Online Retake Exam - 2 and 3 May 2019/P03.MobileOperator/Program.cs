using System;

namespace P03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int month = int.Parse(Console.ReadLine());
            double priceInternet = 0;
            double totalPrice = 0;
            double price = 0;
            double sum = 0;

            if (term=="one")
            {
                if (typeContract=="Small")
                {
                    price = 9.98;
                }
                else if (typeContract=="Middle")
                {
                    price = 18.99;
                }
                else if (typeContract=="Large")
                {
                    price = 25.98;
                }
                else if (typeContract=="ExtraLarge")
                {
                    price = 35.99;
                }

                if (internet=="yes" && price<=10)
                {
                    priceInternet = 5.5;
                }
                else if (internet=="yes" && price<=30)
                {
                    priceInternet = 4.35;
                }
                else if (internet=="yes" && price>30)
                {
                    priceInternet = 3.85;
                }

                totalPrice = (price + priceInternet) * month;
                Console.WriteLine($"{totalPrice:f2} lv.");
            }

           else if (term == "two")
            {
                if (typeContract == "Small")
                {
                    price = 8.58;
                }
                else if (typeContract == "Middle")
                {
                    price = 17.09;
                }
                else if (typeContract == "Large")
                {
                    price = 23.59;
                }
                else if (typeContract == "ExtraLarge")
                {
                    price = 31.79;
                }

                if (internet == "yes" && price <= 10)
                {
                    priceInternet = 5.5;
                }
                else if (internet == "yes" && price <= 30)
                {
                    priceInternet = 4.35;
                }
                else if (internet == "yes" && price > 30)
                {
                    priceInternet = 3.85;
                }
                else if (internet=="no")
                {
                    priceInternet = 0;
                }

                sum = (price + priceInternet) * month;
                if (term=="two")
                {
                    totalPrice = sum - sum * 0.0375;
                }
                else
                {
                    totalPrice = sum;
                }
               
                Console.WriteLine($"{totalPrice:f2} lv.");
            }


        }
    }
}
