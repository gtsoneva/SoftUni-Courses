using System;

namespace P08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());

            double sum = 0;
            double difference = 0;
            double maxDifference = 0;

            for (int i=0; i<num; i++)
            {
                double num1 = int.Parse(Console.ReadLine());
                double num2 = int.Parse(Console.ReadLine());
                double currentSum = num1 + num2;
                if (i==0)
                {
                    sum = currentSum;
                }
                else
                {
                    difference = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (difference>maxDifference)
                {
                    maxDifference = difference;

                }
                
            }

            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={difference}");
            }
        }
    }
}
