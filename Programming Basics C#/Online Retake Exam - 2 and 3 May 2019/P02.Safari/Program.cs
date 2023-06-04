using System;

namespace P02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double quantityGas = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double needGas = quantityGas * 2.10;
            double price = needGas + 100;

            if (day=="Saturday")
            {
                price -= price * 0.10;
            }
            else if (day=="Sunday")
            {
                price -= price * 0.2;
            }

            if (budget>= price)
            {
                Console.WriteLine($"Safari time! Money left: {budget-price:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {price-budget:f2} lv.");
            }
        }
    }
}
