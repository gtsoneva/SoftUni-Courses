using System;

namespace P01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double price = 0;
            if (typeProjection == "Premiere")
            {
                price = 12;
            }
            else if (typeProjection == "Normal")
            {
                price = 7.5;
            }
            else if (typeProjection== "Discount")
            {
                price = 5;
            }
            double totalSum = rows * colums * price;
            Console.WriteLine ($"{totalSum:f2} leva");
        }
    }
}
