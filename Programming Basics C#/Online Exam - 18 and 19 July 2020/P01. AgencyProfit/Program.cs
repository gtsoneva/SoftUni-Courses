using System;

namespace P01._AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameCompany = Console.ReadLine();
            int ticketForAdult = int.Parse(Console.ReadLine());
            int ticketForKids = int.Parse(Console.ReadLine());
            double priceTicketAdult = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double priceTicketKid = priceTicketAdult - (priceTicketAdult *0.7);
            double priceAdult = priceTicketAdult + tax;
            double priceKid = priceTicketKid + tax;
            double totalPrice = (ticketForAdult * priceAdult) + (ticketForKids * priceKid);
            

            Console.WriteLine($"The profit of your agency from {nameCompany} tickets is {totalPrice * 0.2:f2} lv.");

        }
    }
}
