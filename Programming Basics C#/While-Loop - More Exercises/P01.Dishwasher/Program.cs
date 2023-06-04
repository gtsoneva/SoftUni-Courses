using System;

namespace P01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int countsBottles = int.Parse(Console.ReadLine());
            int bottlesValue = countsBottles * 750;
            int plate = 5;
            int pot = 15;
            int plateCount = 0;
            int potCount = 0;
            int washerCount = 0;
            string command;

            while (bottlesValue>=0 )
            {
                command = Console.ReadLine();
                washerCount++;
                if (command == "End")
                {
                    
                    break;
                }
                int input = int.Parse(command);

                

                if (washerCount==3) 
                {
                    potCount += input;
                    input *= pot;
                    bottlesValue -= input;
                    washerCount = 0;
                }
                else
                {

                    plateCount += input;
                    input *= plate;
                    bottlesValue -= input;
                }
            }
            if (bottlesValue>=0)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{plateCount} dishes and {potCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {bottlesValue} ml.");

            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesValue)} ml. more necessary!");
            }

        }
    }
}
