using System;

namespace P04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetActor = double.Parse(Console.ReadLine());
         

            string input = Console.ReadLine();

            while (input!="ACTION")
            {
                if(input.Length <= 15)
                {
                    double remuneration = double.Parse(Console.ReadLine());
                    budgetActor = budgetActor - remuneration;
                }
                else
                {
                    budgetActor = budgetActor - (budgetActor * 0.2);
                }

                if (budgetActor<=0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (budgetActor>=0)
            {
                Console.WriteLine($"We are left with {budgetActor:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(budgetActor):f2} leva for our actors.");
            }
        }
    }
}
