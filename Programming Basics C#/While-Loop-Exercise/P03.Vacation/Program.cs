using System;

namespace P03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForexcursion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spedingCount = 0;

            while (availableMoney < moneyForexcursion && spedingCount < 5)
            {
                string comand = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCount++;
                if (comand == "save")
                {
                    availableMoney += money;
                    spedingCount = 0;
                }
                else
                {
                    spedingCount++;


                    if (spedingCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                    availableMoney -= money;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }
            if (availableMoney>=moneyForexcursion)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
