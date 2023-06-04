using System;

namespace P03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int ticket = int.Parse(Console.ReadLine());
            double priceTicket = 0;

            if (nameFilm == "A Star Is Born")
            {


                if (typeHall == "normal")
                {
                    priceTicket = ticket * 7.50;
                }
                else if (typeHall=="luxury")
                {
                    priceTicket = ticket * 10.50;
                }
                else if (typeHall=="ultra luxury")
                {
                    priceTicket = ticket * 13.50;
                }
            }
            else if (nameFilm== "Bohemian Rhapsody")
            {
                if (typeHall == "normal")
                {
                    priceTicket = ticket * 7.35;
                }
                else if (typeHall == "luxury")
                {
                    priceTicket = ticket * 9.45;
                }
                else if (typeHall == "ultra luxury")
                {
                    priceTicket = ticket * 12.75;
                }
            }

            else if (nameFilm== "Green Book")
            {
                if (typeHall == "normal")
                {
                    priceTicket = ticket * 8.15;
                }
                else if (typeHall == "luxury")
                {
                    priceTicket = ticket * 10.25;
                }
                else if (typeHall == "ultra luxury")
                {
                    priceTicket = ticket * 13.25;
                }
            }
            else if (nameFilm=="The Favourite")
            {
                if (typeHall == "normal")
                {
                    priceTicket = ticket * 8.75;
                }
                else if (typeHall == "luxury")
                {
                    priceTicket = ticket * 11.55;
                }
                else if (typeHall == "ultra luxury")
                {
                    priceTicket = ticket * 13.95;
                }
            }

            Console.WriteLine($"{nameFilm} -> {priceTicket:F2} lv.");
        }
    }
}
