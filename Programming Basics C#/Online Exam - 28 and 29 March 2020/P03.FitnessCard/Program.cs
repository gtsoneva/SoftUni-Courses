using System;

namespace P03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;
            if (sport=="Gym")
            {
                if (sex == 'm')
                {
                    price = 42;
                }
                else
                {
                    price = 35;
                }
                if (age<19)
                {
                    price -= price * 0.2;
                }
            }
           else if (sport == "Boxing")
            {
                if (sex == 'm')
                {
                    price = 41;
                }
                else
                {
                    price = 37;
                }
                if (age < 19)
                {
                    price -= price * 0.2;
                }
            }
            else if (sport == "Yoga")
            {
                if (sex == 'm')
                {
                    price = 45;
                }
                else
                {
                    price = 42;
                }
                if (age < 19)
                {
                    price -= price * 0.2;
                }
            }
            else if (sport == "Zumba")
            {
                if (sex == 'm')
                {
                    price = 34;
                }
                else
                {
                    price = 31;
                }
                if (age < 19)
                {
                    price -= price * 0.2;
                }
            }
            else if (sport == "Dances")
            {
                if (sex == 'm')
                {
                    price = 51;
                }
                else
                {
                    price = 53;
                }
                if (age < 19)
                {
                    price -= price * 0.2;
                }
            }
            else if (sport == "Pilates")
            {
                if (sex == 'm')
                {
                    price = 39;
                }
                else
                {
                    price = 37;
                }
                if (age < 19)
                {
                    price -= price * 0.2;
                }
            }

            if (budget>= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${price-budget:f2} more.");
            }
        }
    }
}
