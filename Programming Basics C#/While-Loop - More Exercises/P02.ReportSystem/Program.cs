using System;

namespace P02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine(); 
            int payCash = 0;
            int payCard = 0;
            int payCashCounter = 0;
            int payCardCounter = 0;
            int paymentCounter = 0;

            while (input  != "End")
            {
                paymentCounter++;
                int priceObjects = int.Parse(input);


                if (paymentCounter % 2 != 0 && priceObjects <= 100)
                {
                    payCashCounter++;
                    totalSum -= priceObjects;
                    payCash += priceObjects;
                    Console.WriteLine($"Product sold!");
                }
               


                else if (paymentCounter % 2 == 0 && priceObjects >= 10)

                {
                    payCardCounter++;
                    totalSum -= priceObjects;
                    payCard += priceObjects;
                    Console.WriteLine($"Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                  
                }

              


                if (totalSum <= 0)
                {
                    Console.WriteLine($"Average CS: {(double)payCash / payCashCounter:f2}");
                    Console.WriteLine($"Average CC: {(double)payCard / payCardCounter:f2}");
                    break;
                }
                input = Console.ReadLine();
            }



            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }

           

        }
    }
}
