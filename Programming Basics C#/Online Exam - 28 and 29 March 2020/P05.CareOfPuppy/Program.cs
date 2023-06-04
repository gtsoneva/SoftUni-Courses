using System;

namespace P05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityBuyFood = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double totalFood = 0;

            while (input!="Adopted")
            {
                int foodPerDay = int.Parse(input);

                totalFood += foodPerDay;
                if (input=="Adopted")
                {
                    break;
                }
                input = Console.ReadLine();
            }

            int foodInGr = quantityBuyFood * 1000;

            if (foodInGr>= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGr-totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood-foodInGr} grams more.");
            }
        }
    }
}
