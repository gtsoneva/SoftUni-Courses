using System;

namespace P08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           int grade = 1;
            int classRepetition = 0;
            double marksSum = 0;
            while (grade<=12)
            {
                double currentGradeMark = double.Parse(Console.ReadLine());
                if (currentGradeMark<4)
                {
                    classRepetition++;
                    if (classRepetition>1)
                    {
                       
                        break;
                    }
                    continue;
                }
                marksSum += currentGradeMark;
                grade++;
            }
            double average = marksSum / 12;
            if (classRepetition>1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
