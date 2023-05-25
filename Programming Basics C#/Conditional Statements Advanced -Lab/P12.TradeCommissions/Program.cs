using System;

namespace P12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;

            if (town=="Sofia")
            {
                if (sales>=0 && sales<=500)
                {
                    commission = 0.05;
                }
              else if (sales>500 && sales <=1000)
                {
                    commission = 0.07;
                }
             else  if (sales>1000 && sales <=10000)
                {
                    commission = 0.08;
                }
                else if (sales>10000)
                {
                    commission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
         
           else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.10;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town=="Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
           double totalCommission = commission * sales;

          
            if ( totalCommission > 0)

            {
                Console.WriteLine($"{totalCommission:f2}");
            }
        }
    }
}
