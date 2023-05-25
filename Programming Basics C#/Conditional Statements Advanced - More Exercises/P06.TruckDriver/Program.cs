using System;

namespace P06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());

            double priceForKm = 0;

            if (kmForMonth<=5000)
            {
                if (season=="Spring" || season=="Autumn")
                {
                    priceForKm = 0.75;
                }
                else if (season=="Summer")
                {
                    priceForKm = 0.90;
                }
                else
                {
                    priceForKm = 1.05;
                }
            }

           else if (kmForMonth> 5000 && kmForMonth<=10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    priceForKm = 0.95;
                }
                else if (season == "Summer")
                {
                    priceForKm = 1.10;
                }
                else
                {
                    priceForKm = 1.25;
                }
            }

            else
            {
                priceForKm = 1.45;
            }

            double salary = (kmForMonth * priceForKm) * 4;
            double totalSalary = salary - salary * 0.10;

            Console.WriteLine($"{totalSalary:f2}");
        }
    }
}
