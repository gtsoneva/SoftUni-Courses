using System;

namespace P02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minWalk = int.Parse(Console.ReadLine());
            int quantityWalkForAday = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            int walk = minWalk * quantityWalkForAday;
            int burnsCalories = walk * 5;
            int consumedCalories = caloriesPerDay / 2;

            if (burnsCalories>=consumedCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnsCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnsCalories}.");
            }
        }
    }
}
