using System;

namespace P10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oodSum = 0;

            for (int i = 0; i < n ; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(i %2==0 )
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oodSum += currentNumber;
                }

            }
            if (evenSum == oodSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oodSum)}");
            }
        }
    }
}
