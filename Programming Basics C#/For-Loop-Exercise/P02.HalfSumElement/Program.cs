using System;

namespace P02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sum += currentNumber;

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            
            sum -= maxNumber;
            if (maxNumber == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
           
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");
            }
        }
    }
}
