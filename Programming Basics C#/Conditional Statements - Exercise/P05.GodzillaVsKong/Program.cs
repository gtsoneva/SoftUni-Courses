using System;

namespace P05.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата 

            //Бюджет за филма – реално число в интервала [1.00 … 1000000.00]

            double budgetOfFilm = double.Parse(Console.ReadLine());

            //Брой на статистите – цяло число в интервала[1 … 500]

            int stunts = int.Parse(Console.ReadLine());

            //.Цена за облекло на един статист – реално число в интервала[1.00 … 1000

            double priceClotingStunts = double.Parse(Console.ReadLine());

            //2  •	Декорът за филма е на стойност 10% от бюджета. 


            double decor = budgetOfFilm * 0.1;
            double sumClotingStunts = stunts * priceClotingStunts;

            //При повече от 150 статиста,  има отстъпка за облеклото на стойност 10%.
            if (stunts > 150)
            {
                sumClotingStunts = sumClotingStunts - sumClotingStunts * 0.10;

            }
            else 
            {
                sumClotingStunts = sumClotingStunts;
            }
            // Печатаме на конзолата 2 изхода 

            //•	1 Ако  парите за декора и дрехите са повече от бюджета: "Not enough money!"
            // "Wingard needs {парите недостигащи за филма} leva more."
            if (decor+sumClotingStunts> budgetOfFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs (budgetOfFilm - (decor + sumClotingStunts)):F2} leva more.");

            }
            //2.Ако парите за декора и дрехите са по малко или равни на бюджета: "Action!" "Wingard starts filming with {останалите пари} leva left."
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetOfFilm - (decor + sumClotingStunts):F2} leva left.");
            }

        
        }
    }
}
