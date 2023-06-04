using System;

namespace P02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());

            int evoluationSum = 0;
            int evoluationCount = 0;
            int filledCount = 0;
            string lastExercise = string.Empty;

            string input = Console.ReadLine();
            int evoluation;

            while (input != "Enough")
            {
                lastExercise = input;
                evoluation = int.Parse (Console.ReadLine());

                evoluationSum += evoluation;
                evoluationCount++;

                if (evoluation<=4)
                {
                    filledCount++;

                    if(filledCount ==failedTimes)
                    {
                        Console.WriteLine($"You need a break, { filledCount} poor grades.");
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            if (input=="Enough")
            {
               
               
                Console.WriteLine($"Average score: {(double)evoluationSum / evoluationCount:f2}");
                Console.WriteLine($"Number of problems: {evoluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");

            }
        }
    }
}
