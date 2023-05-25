using System;

namespace P02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJuniors = int.Parse(Console.ReadLine());
            int numSeniors = int.Parse(Console.ReadLine());
            string route= Console.ReadLine();

            double taxesJuniors = 0;
            double taxesSeniors = 0;

            switch (route)
            { 
                case "trail":
            taxesJuniors = 5.50;
                taxesSeniors = 7;
                break;

                case "cross-country":
            taxesJuniors = 8;
                taxesSeniors = 9.50;
                    if ((numJuniors+numSeniors)>=50)
                    {
                        taxesJuniors = taxesJuniors - taxesJuniors * 0.25;
                        taxesSeniors =  taxesSeniors- taxesSeniors * 0.25;
                    }
                break;
                  case "downhill":
            taxesJuniors = 12.25;
                taxesSeniors = 13.75;
                break;
                   case "road":
            taxesJuniors = 20;
                taxesSeniors = 21.50;
                break;

            }
            double sum = (taxesJuniors * numJuniors) + (taxesSeniors * numSeniors);
            double totalSum = sum - sum * 0.05;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
