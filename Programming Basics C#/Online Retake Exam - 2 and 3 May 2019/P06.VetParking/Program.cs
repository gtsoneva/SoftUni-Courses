using System;

namespace P06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursForPerDay = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int d = 1; d <= days; d++)
            {
                double tax = 0;
                double currentSum = 0;
                for (int h = 1; h <= hoursForPerDay; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        tax = 2.50;
                        currentSum += tax;
                    }
                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        tax = 1.25;
                        currentSum += tax;
                    }
                    else
                    {
                        tax = 1;
                        currentSum += tax;
                    }
                }
                totalSum = totalSum + currentSum;
                Console.WriteLine($"Day: {d} - {currentSum:f2} leva");

            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
