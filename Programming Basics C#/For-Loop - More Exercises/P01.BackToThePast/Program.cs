using System;

namespace P01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            double moneyForSpend = 0.00;
            double age = 19.0;

            for (int i=1800; i<=yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyForSpend+= 12000;
                }
                else
                {
                    
                    moneyForSpend += 12000 + 50* age ;
                    age += 2;
                }

            }
            
            if (inheritedMoney>=moneyForSpend)
            {
                double n = inheritedMoney - moneyForSpend;

                Console.WriteLine($"Yes! He will live a carefree life and will have {n:f2} dollars left.");
            }
            else
            {
                double m = moneyForSpend - inheritedMoney;
                Console.WriteLine($"He will need {m:f2} dollars to survive.");
            }
        }
    }
}
