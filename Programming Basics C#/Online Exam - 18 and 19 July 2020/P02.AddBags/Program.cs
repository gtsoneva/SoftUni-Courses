using System;

namespace P02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaggageMore20kg = double.Parse(Console.ReadLine());
            double kgBaggage = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int countBaggage = int.Parse(Console.ReadLine());
            double price = 0;

            if (kgBaggage<10)
            {
                price = priceBaggageMore20kg * 0.2;
            }
            else if (kgBaggage<=20)
            {
                price = priceBaggageMore20kg / 2;
            }
            else if (kgBaggage>20)
            {
                price = priceBaggageMore20kg;
            }

            if (days<7)
            {
                price += price * 0.4;
            }
            else if (days<=30)
            {
                price += price * 0.15;
            }
            else if (days>30)
            {
                price += price * 0.1;
            }
            double totalPrice = price * countBaggage;
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
