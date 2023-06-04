using System;

namespace P05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEggs = int.Parse(Console.ReadLine());

            int countRed = 0;
            int countOrange = 0;
            int countBlue = 0;
            int countGreen = 0;
            
            

            for (int i = 1; i <= quantityEggs; i++)
            {
                string egg = Console.ReadLine();

                if (egg=="red")
                {
                    countRed++;

                    
                }
                else if (egg=="orange")
                {
                    countOrange++;
                }
                else if (egg=="blue")
                {
                    countBlue++;
                }
                else if (egg=="green")
                {
                    countGreen++;
                }

            }

            double maxEggs = countRed;
            string maxColor= "red";

            if (countOrange>maxEggs)
            {
                maxEggs = countOrange;
                maxColor = "orange";
            }
            if (countBlue>maxEggs)
            {
                maxEggs = countBlue;
                maxColor = "blue";
            }
            if (countGreen>maxEggs)
            {
                maxEggs = countGreen;
                maxColor = "green";
            }

            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");


        }
    }
}
