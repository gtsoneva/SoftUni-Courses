
using System;

namespace P06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEasterBread = int.Parse(Console.ReadLine());
            string bestBaker = " ";
            int bestAssesment = 0;
            string input = "";
            int countBaker = 0;
            for (int i = 1; i <= quantityEasterBread; i++)
            {

                int totalPoint = 0;
                string nameOfBaker = Console.ReadLine();
                input = Console.ReadLine();
                countBaker++;

                while (input != "Stop")
                {
                    int assessment = int.Parse(input);

                    totalPoint += assessment;


                    input = Console.ReadLine();
                    if (input == "Stop")
                    {

                        break;
                    }

                }



                if (input == "Stop")
                {
                    Console.WriteLine($"{nameOfBaker} has {totalPoint} points.");



                }

                if (totalPoint > bestAssesment)
                {
                    bestAssesment = totalPoint;
                    bestBaker = nameOfBaker;
                    Console.WriteLine($"{bestBaker} is the new number 1!");
                }

            }

            Console.WriteLine($"{bestBaker} won competition with {bestAssesment} points!");
        }
    }
}