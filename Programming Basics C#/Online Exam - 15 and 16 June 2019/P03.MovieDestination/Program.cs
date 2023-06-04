using System;

namespace P03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            if (destination=="Dubai")
            {
                if (season=="Winter")
                {
                    price = 45000;
                }
                else
                {
                    price = 40000;
                }
                price -= price * 0.30;
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    price = 17000;
                }
                else
                {
                    price = 12500;
                }
                price += price * 0.25;
            }
          else  if (destination == "London")
          {
                if (season == "Winter")
                {
                    price = 24000;
                }
                else
                {
                    price = 20250;
                }

          }
            double totalPrice = price * days;
            if (totalPrice<budget)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice-budget:f2} leva more!");
            }

        }
    }
}
