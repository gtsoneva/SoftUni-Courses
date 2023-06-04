using System;

namespace P03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJoinery = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();
            string methodOfReceipt = Console.ReadLine();
            double price = 0;

            if (countJoinery<10)
            {
                Console.WriteLine("Invalid order");
            }

            if (typeJoinery=="90X130")
            {
                price = countJoinery * 110;
                if (countJoinery>30 && countJoinery<=60)
                {
                    price -= price * 0.05;
                }
                else if (countJoinery>60)
                {
                    price -= price * 0.08;
                }
            }
            else if (typeJoinery=="100X150")
            {
                price = countJoinery * 140;
                if (countJoinery > 40 && countJoinery<=80)
                {
                    price -= price * 0.06;
                }
                else if (countJoinery > 80)
                {
                    price -=price * 0.10;
                }
            }
            else if (typeJoinery == "130X180")
            {
                price = countJoinery * 190;
                if (countJoinery > 20 && countJoinery<=50)
                {
                    price -= price * 0.07;
                }
                else if (countJoinery > 50)
                {
                    price -= price * 0.12;
                }
            }
            else if (typeJoinery == "200X300")
            {
                price = countJoinery * 250;
                if (countJoinery > 25 && countJoinery<=50)
                {
                    price -= price * 0.09;
                }
                else if (countJoinery >50)
                {
                    price -= price * 0.14;
                }
            }

            if (methodOfReceipt == "With delivery")
            {
                price = price + 60;
            }

            if (countJoinery>=100)
            {
                price-=price * 0.04;
            }
            if (countJoinery >= 10)
            {
                Console.WriteLine($"{price:f2} BGN");
            }
        }
    }
}
