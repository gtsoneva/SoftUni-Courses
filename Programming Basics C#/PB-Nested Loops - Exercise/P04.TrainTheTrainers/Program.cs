using System;

namespace P04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJury = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

           
            
            double totalGradeSum = 0;
            int presentationNum = 0;
            while (input != "Finish")
            {
                string presentation = input;

                double gradeSum = 0;
                for (int i = 1; i <= numJury; i++)
                {
                    
                    gradeSum += double.Parse(Console.ReadLine());
                }
            
                 gradeSum = gradeSum / numJury;
                totalGradeSum += gradeSum;

                Console.WriteLine($"{presentation} - {gradeSum:f2}.");
                presentationNum++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalGradeSum / presentationNum:f2}.");
        }

    }
}







