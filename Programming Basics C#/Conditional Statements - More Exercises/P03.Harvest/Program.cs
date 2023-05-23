using System;

namespace P03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //•	1ви ред: X кв.м е лозето – цяло число в интервала [10 … 5000]

            int vineyardSquareMeters = int.Parse(Console.ReadLine());

            //2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]

            double grapesSquareMeters = double.Parse(Console.ReadLine());

            //3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]

            int litersWine = int.Parse(Console.ReadLine());

            //4ти ред: брой работници – цяло число в интервала[1 … 20]

            int numOfWorkers = int.Parse(Console.ReadLine());

            //2.Намираме общото грозде и вино
            //От лозе с площ X квадратни метри се заделя 40% от реколтата за производство на вино.
            //От 1 кв.м лозе се изкарват Y килограма грозде.
            //За 1 литър вино са нужни 2,5 кг. грозде.
            //Желаното количество вино за продан е Z литра.
            double grapes = vineyardSquareMeters * grapesSquareMeters;
            double wine = 0.4 * grapes / 2.5;

            if (wine >= litersWine)
            {
                double remainingWine = wine - litersWine;
                double winePerOneWorker = remainingWine / numOfWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(remainingWine)} liters left -> {Math.Ceiling(winePerOneWorker)} liters per person.");
            }
            else
            {
                double remainingWine = litersWine - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(remainingWine)} liters wine needed.");
            }

        }
    }
}
