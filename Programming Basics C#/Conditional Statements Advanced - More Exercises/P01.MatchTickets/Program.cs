using System;

namespace P01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categoryTicket = Console.ReadLine();
            int numPeople = int.Parse(Console.ReadLine());

            double transportPrice = 0.00;
            double priceTicket = 0.00;

            if (numPeople >=1 && numPeople <=4)
            {
                transportPrice= budget * 0.75;
            }
            else if (numPeople >= 5 && numPeople <=9)
            {
                transportPrice = budget * 0.6;
            }
            else if (numPeople >= 10 && numPeople <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (numPeople >= 25 && numPeople <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else 
            {
                transportPrice = budget * 0.25;
            }

            double moneyLeft = budget - transportPrice;

            if (categoryTicket == "VIP")
            {
                priceTicket = numPeople *499.99;
            }
            else
            {
                priceTicket = numPeople * 249.99;
            }

          
            if (priceTicket<=moneyLeft)
            {
                Console.WriteLine($"Yes! You have { (moneyLeft- priceTicket):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft-priceTicket):F2} leva.");
            }
        }
    }
}
