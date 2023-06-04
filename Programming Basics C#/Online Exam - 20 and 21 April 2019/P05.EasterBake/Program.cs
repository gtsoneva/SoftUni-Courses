using System;

namespace P05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEasterBread = int.Parse(Console.ReadLine());
           double totalNeedSugar = 0;
            double totalNeedFlour = 0;
            int maxUsedSugar = 0;
            int maxUsedFlour = 0;

            for (int i = 1; i <= quantityEasterBread; i++)
            {
                int usedSugar = int.Parse(Console.ReadLine());
                int usedFlour = int.Parse(Console.ReadLine());

                totalNeedSugar += usedSugar;
                totalNeedFlour += usedFlour;

                if (maxUsedFlour<usedFlour)
                {
                    maxUsedFlour = usedFlour;
                }
                if (maxUsedSugar< usedSugar)
                {
                    maxUsedSugar = usedSugar;
                }


            }

         double needPacetSugar = Math.Ceiling(totalNeedSugar / 950);
            double needPacetFlour = Math.Ceiling(totalNeedFlour / 750);


            Console.WriteLine($"Sugar: {needPacetSugar}");
            Console.WriteLine($"Flour: {needPacetFlour}");
            Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");

        }
    }
}
