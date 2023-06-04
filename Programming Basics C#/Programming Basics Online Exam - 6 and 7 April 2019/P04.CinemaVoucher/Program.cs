using System;

namespace P04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int vaucher = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int moviePrice = 0;
            int productPrice = 0;
            int purchasedProducts = 0;
            int purchasedTickets = 0;

            while (input!="End")
            {

                if (input.Length > 8)
                {
                    moviePrice = input[0] + input[1];
                    if (vaucher < moviePrice)
                    {
                        Console.WriteLine($"{purchasedTickets}");
                        Console.WriteLine($"{purchasedProducts}");
                        break;
                    }
                    vaucher -= moviePrice;
                    purchasedTickets++;
                }
                else if (input.Length <= 8)
                {
                    productPrice = input[0];
                    if (vaucher < productPrice)
                    {
                        Console.WriteLine($"{purchasedTickets}");
                        Console.WriteLine($"{purchasedProducts}");
                        break;
                    }
                    vaucher -= productPrice;
                    purchasedProducts++;
                }
                input = Console.ReadLine();
            }
            if (input=="End")
            {
                Console.WriteLine($"{purchasedTickets}");
                Console.WriteLine($"{purchasedProducts}");
            }
        }
    }
}
