using System;

namespace P04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //•	Първият ред съдържа числото n – брой километри – цяло число в интервала [1…5000]

            int kilometers = int.Parse(Console.ReadLine());

            //Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта
            string dayOrNight = Console.ReadLine();
            double price = 0;
            double taxi = 0;
            if (dayOrNight == "day")
            {
                taxi = 0.79;
            }
            else
            {
                taxi = 0.90;
            }
            if (kilometers < 20)
                price = 0.70 + kilometers * taxi;
            else if (kilometers< 100)
            {
                price = kilometers * 0.09;

            }
            else
            {
                price = kilometers * 0.06;
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
