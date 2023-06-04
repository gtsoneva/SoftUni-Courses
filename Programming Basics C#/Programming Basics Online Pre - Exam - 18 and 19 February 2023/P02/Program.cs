using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int leftFoodKg = int.Parse(Console.ReadLine());
           double foodPerDayForFirstDeer = double.Parse(Console.ReadLine());
            double foodPerDayForSecondDeer = double.Parse(Console.ReadLine());
            double foodPerDayForThirdDeer = double.Parse(Console.ReadLine());

            double needFoodForFirstDeer = countDays * foodPerDayForFirstDeer;
            double needFoodForSecondDeer = countDays * foodPerDayForSecondDeer;
            double needFoodForThirdDeer = countDays * foodPerDayForThirdDeer;

            double totalNeedFood = needFoodForFirstDeer + needFoodForSecondDeer + needFoodForThirdDeer;

            if (totalNeedFood<leftFoodKg)
            {
                Console.WriteLine($"{Math.Floor(Math.Abs(totalNeedFood-leftFoodKg))} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(Math.Abs(leftFoodKg-totalNeedFood))} more kilos of food are needed.");
            }
        }
    }
}
