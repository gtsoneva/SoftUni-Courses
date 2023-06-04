using System;

namespace P04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityEggs = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double eggs = 0;
            double buyEggs = 0;

            while (input!="Close")
            {
                 eggs = double.Parse(Console.ReadLine());



                if (input=="Buy")
                {
                    if (quantityEggs < eggs)
                    {
                        break;
                    }
                    buyEggs += eggs;
                        quantityEggs = quantityEggs - eggs;

                }
                else
                {
                    quantityEggs = quantityEggs + eggs;
                }

                if (input=="Close")
                {
                    break;
                }
                input = Console.ReadLine();

            }

                if (input=="Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{buyEggs} eggs sold.");
            }

               else if (quantityEggs<eggs)
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {quantityEggs}.");
            }
        }
    }
}
