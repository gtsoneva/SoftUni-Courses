using System;

namespace P05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <=num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                sum += currentNum;
            }
            double average = sum / num;
            Console.WriteLine($"{average:f2}");
        }
    }
}
