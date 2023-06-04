using System;

namespace P04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double quantityFood = double.Parse(Console.ReadLine());
            double cat = 0;
            double dog = 0;
            double totalFood = 0;
            double biscuits = 0;
            double currentBiscuits = 0;
           
            for (int i = 1; i <=days; i++)
            {
               
                int quantityFoodDog = int.Parse(Console.ReadLine());
                int quantityFoodCat = int.Parse(Console.ReadLine());

               
                cat += quantityFoodCat;
                dog += quantityFoodDog;

                if (i%3==0)
                {
                  currentBiscuits= (quantityFoodCat + quantityFoodDog) * 0.1;
                    biscuits += currentBiscuits;
                    }
                totalFood += quantityFoodCat + quantityFoodDog;
            }
           
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{(totalFood/quantityFood)*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dog/totalFood)*100:f2}% eaten from the dog.");
            Console.WriteLine($"{(cat/totalFood)*100:f2}% eaten from the cat.");
        }
    }
}
