using System;

namespace P01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата 
            // V – Обем на басейна в литри – цяло число в интервала [1…10000].
            int V = int.Parse(Console.ReadLine());

            // числото P1 – дебит на първата тръба за час – цяло число в интервала[1…5000].

            int P1 = int.Parse(Console.ReadLine());

            // числото P2 – дебит на втората тръба за час– цяло число в интервала[1…5000].

            int P2 = int.Parse(Console.ReadLine());
            //числото H – часовете които работникът отсъства – реално число в интервала[1.0…24.00]
            double H = double.Parse(Console.ReadLine());


            //2 Изчисляваме колко се е напълнил басейна от първата и втората тръба за времето в което работникът отсъства
            double water = P1 * H + P2 * H;
           



            // Печатаме на конзолата 
            //	До колко се е запълнил басейна и коя тръба с колко процента е допринесла. "The pool is {запълненост на басейна в проценти}% full. Pipe 1: {процент вода от първата тръба}%. Pipe 2: {процент вода от втората тръба}%."

            if (water <= V)
            {
                double waterPersent = water / V * 100;
                double p1Persent = P1 * H / water * 100;
                double p2Persent = P2 * H / water * 100;
                Console.WriteLine($"The pool is {waterPersent:F2} % full. Pipe 1: {p1Persent:F2} %. Pipe 2: {p2Persent:F2} %.");
            }
            else
            {
                double waterMore = water - V;
                Console.WriteLine($"For {H:F2} hours the pool overflows with { waterMore:F2} liters.");
            }
            //Aко басейнът се е препълнил – с колко литра е прелял за даденото време."For {часовете, които тръбите са пълнили вода} hours the pool overflows with {литрите вода в повече} liters."

        }
    }
}
