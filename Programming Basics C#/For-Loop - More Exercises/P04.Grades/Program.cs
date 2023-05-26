using System;

namespace P04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());

            double failStudents = 0;
            double studentsTo4 = 0;
            double studentsTo5 = 0;
            double topStudents = 0;
            double average = 0;

            for (int i = 1; i <=numStudents; i++)
            {
                double assessmentStudent = double.Parse(Console.ReadLine());

                if (assessmentStudent <= 2.99)
                {
                    failStudents++;
                }
                else if (assessmentStudent <= 3.99)
                {
                    studentsTo4++;
                }
                else if (assessmentStudent <= 4.99)
                {
                    studentsTo5++;
                }
                else
                {
                    topStudents++;
                }

                average = average + assessmentStudent;
            }

            Console.WriteLine($"Top students: {(topStudents/numStudents)*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(studentsTo5/numStudents)*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(studentsTo4/numStudents)*100:f2}%");
            Console.WriteLine($"Fail: {(failStudents/numStudents)*100:f2}%");
            Console.WriteLine($"Average: {average/numStudents:f2}");

        }
    }
}
