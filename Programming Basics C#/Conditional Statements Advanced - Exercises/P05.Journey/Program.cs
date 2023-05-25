using System;

namespace P05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            double spendMoney = 0;
            string place = string.Empty;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    spendMoney = budget * 0.30;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    spendMoney =  budget * 0.70;
                }

            }

            if (budget >100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    spendMoney = budget * 0.40;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    spendMoney = budget * 0.80;
                }
            }


            if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                spendMoney = budget * 0.90;
                
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {spendMoney:f2}");
        }
    }
}
