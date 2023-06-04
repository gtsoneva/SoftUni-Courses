using System;

namespace P04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double totalPrice = 0;
            double money = 0;

            while (input!= "Party!")
            {
                int countCocktails = int.Parse(Console.ReadLine());
                double price = input.Length;
                totalPrice = countCocktails * price;
                 if (totalPrice %2!=0)
                {
                    totalPrice = totalPrice - totalPrice * 0.25;
                }
                money += totalPrice;
                if (money>= desiredProfit)
                {
                    Console.WriteLine($"Target acquired.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input== "Party!")
            {
                Console.WriteLine($"We need {Math.Abs(money- desiredProfit):f2} leva more.");
            }
            Console.WriteLine($"Club income - {money:f2} leva.");
        }
    }
}
