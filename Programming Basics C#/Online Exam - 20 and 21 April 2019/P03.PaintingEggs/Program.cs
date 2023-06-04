using System;

namespace P03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string colorEggs = Console.ReadLine();
            int batchEggs = int.Parse(Console.ReadLine());

            double price = 0;

            if (sizeEggs=="Large")
            {
                if (colorEggs=="Red")
                {
                    price = 16;
                }
                else if (colorEggs=="Green")
                {
                    price = 12;
                }
                else if (colorEggs=="Yellow")
                {
                    price = 9;
                }
            }

           else if (sizeEggs == "Medium")
            {
                if (colorEggs == "Red")
                {
                    price = 13;
                }
                else if (colorEggs == "Green")
                {
                    price = 9;
                }
                else if (colorEggs == "Yellow")
                {
                    price = 7;
                }
            }

           else if (sizeEggs == "Small")
            {
                if (colorEggs == "Red")
                {
                    price = 9;
                }
                else if (colorEggs == "Green")
                {
                    price = 8;
                }
                else if (colorEggs == "Yellow")
                {
                    price = 5;
                }
            }

            double totalPrice = (price * batchEggs) - ((price * batchEggs) * 0.35);

            Console.WriteLine($"{totalPrice:f2} leva.");
        }
    }
}
