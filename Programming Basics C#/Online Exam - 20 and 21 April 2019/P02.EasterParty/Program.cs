using System;

namespace P02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            double priceForOnePerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guest>=10 && guest<=15)
            {
                priceForOnePerson -= priceForOnePerson * 0.15;
            }
            else if (guest>15 && guest<=20)
            {
                priceForOnePerson -= priceForOnePerson * 0.2;
            }
            else if (guest>20)
            {
                priceForOnePerson -= priceForOnePerson * 0.25;
            }

            double priceForGuest = priceForOnePerson * guest;
            double priceCake = budget * 0.1;
            double totalPrice = priceForGuest + priceCake;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"It is party time! {budget-totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalPrice-budget:f2} leva needed.");
            }



        }
    }
}
