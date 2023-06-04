using System;

namespace P05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countSerials = int.Parse(Console.ReadLine());

            double totalPrice = 0; 

            for (int i = 1; i <= countSerials; i++)
            {
                string nameSerial = Console.ReadLine();
                double priceSerial = double.Parse(Console.ReadLine());


                if (nameSerial=="Thrones")
                {
                    priceSerial -= priceSerial * 0.5;
                }
                else if (nameSerial=="Lucifer")
                {
                    priceSerial -= priceSerial * 0.4;
                }
                else if (nameSerial == "Protector")
                {
                    priceSerial -= priceSerial * 0.3;
                }
                else if (nameSerial == "TotalDrama")
                {
                    priceSerial -= priceSerial * 0.2;
                }
                else if (nameSerial == "Area")
                {
                    priceSerial -= priceSerial * 0.1;
                }

                totalPrice += priceSerial;
            }

            if (budget>= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget-totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalPrice-budget:f2} lv. more to buy the series!");
            }
        }
    }
}
