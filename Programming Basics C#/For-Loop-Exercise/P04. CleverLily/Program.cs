using System;

namespace P04._CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceOneToy=int.Parse(Console.ReadLine());

            
            double savings = 0;

            for (int i=1; i<= ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    savings += i * 5 - 1;
                }
                else
                {
                    savings += priceOneToy;
                }

            }

            
            
            if (savings >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {savings - priceWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(priceWashingMachine - savings):f2}");
            }
        }
    }
}
