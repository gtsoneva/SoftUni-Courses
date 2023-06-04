using System;

namespace P03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string championshipStage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int ticket = int.Parse(Console.ReadLine());
            string fotoWithTrophy = Console.ReadLine();

            double priceTicket = 0;

            if (championshipStage=="Quarter final")
            {
                if (typeTicket == "Standard")
                {
                    priceTicket = 55.5;
                }

                else if (typeTicket=="Premium")
                {
                    priceTicket = 105.20;
                }
                else
                {
                    priceTicket = 118.90;
                }
            }

           else if (championshipStage == "Semi final")
            {
                if (typeTicket == "Standard")
                {
                    priceTicket = 75.88;
                }

                else if (typeTicket == "Premium")
                {
                    priceTicket = 125.22;
                }
                else
                {
                    priceTicket = 300.4;
                }
            }
           else if (championshipStage == "Final")
            {
                if (typeTicket == "Standard")
                {
                    priceTicket = 110.1;
                }

                else if (typeTicket == "Premium")
                {
                    priceTicket = 160.66;
                }
                else
                {
                    priceTicket = 400;
                }
            }

            double totalPriceTicket = priceTicket * ticket;

            if (totalPriceTicket>2500 && totalPriceTicket<=4000)
            {
                totalPriceTicket -=totalPriceTicket * 0.10;

                if (fotoWithTrophy=="Y")
                {
                    totalPriceTicket = totalPriceTicket +(ticket*40);

                }

                Console.WriteLine($"{totalPriceTicket:f2}");
            }

           else if (totalPriceTicket> 4000)
            {
                totalPriceTicket -= totalPriceTicket * 0.25;

                Console.WriteLine($"{totalPriceTicket:f2}");
            }


            else
            {
              

                if (fotoWithTrophy == "Y")
                {
                    totalPriceTicket = totalPriceTicket + (ticket * 40);

                }

                Console.WriteLine($"{totalPriceTicket:f2}");
            }
        }
    }
}
