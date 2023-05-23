using System;

namespace P08.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double allMeters = meters * 7.61;
            double discount = allMeters * 0.18;
            double finalPrice = allMeters - discount;


            Console.WriteLine($"The final price is {finalPrice} lv.");
            Console.WriteLine($"The discount is {discount} lv.");

        }
    }
}
