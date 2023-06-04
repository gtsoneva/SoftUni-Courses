using System;

namespace P03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            string pacetForFilm = Console.ReadLine();
            int ticket = int.Parse(Console.ReadLine());

            double price = 0;

            if (nameFilm== "John Wick")
            {
                if (pacetForFilm=="Drink")
                {
                    price = 12;
                }
                else if (pacetForFilm=="Popcorn")
                {
                    price = 15;
                }
                else if (pacetForFilm=="Menu")
                {
                    price=19;
                }
            }
            else if (nameFilm=="Star Wars")
            {
                if (pacetForFilm == "Drink")
                {
                    price = 18;
                }
                else if (pacetForFilm == "Popcorn")
                {
                    price =25;
                }
                else if (pacetForFilm == "Menu")
                {
                    price = 30;
                }

                if (ticket>=4)
                {
                    price -= price * 0.3;
                }
            }
            else if (nameFilm=="Jumanji")
            {
                if (pacetForFilm == "Drink")
                {
                    price = 9;
                }
                else if (pacetForFilm == "Popcorn")
                {
                    price = 11;
                }
                else if (pacetForFilm == "Menu")
                {
                    price = 14;
                }
                if (ticket==2)
                {
                    price -= price * 0.15;
                }
            }

            double bill = ticket * price;
            Console.WriteLine($"Your bill is {bill:f2} leva.");
        }
    }
}
