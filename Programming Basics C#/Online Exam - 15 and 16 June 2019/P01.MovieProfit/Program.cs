using System;

namespace P01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            int countDay = int.Parse(Console.ReadLine());
            int countTicket = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());

            double priceTicketForPerDay = countTicket * priceTicket;
            double totalPriceTicket = countDay * priceTicketForPerDay;
            double leftForACinema = totalPriceTicket * ((double)procent / 100);

            double income = totalPriceTicket - leftForACinema;





            Console.WriteLine($"The profit from the movie {nameFilm} is {income:f2} lv.");
        }
    }
}
