using System;

namespace P01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double priceChair = double.Parse(Console.ReadLine());
            double priceUmbrella = double.Parse(Console.ReadLine());
            double totalSum = 0;

            double allTax = numPeople * tax;
            double chair = (Math.Ceiling(numPeople * 0.75)) * priceChair;
            double umbrella = (Math.Ceiling(numPeople * 0.50)) * priceUmbrella;
            totalSum = allTax + chair + umbrella;
            Console.WriteLine($"{totalSum:F2} lv.");

        }
    }
}
