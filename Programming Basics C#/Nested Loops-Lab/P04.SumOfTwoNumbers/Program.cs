using System;

namespace P04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationCount = 0;
            bool stop = false;

            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <=end; x2++)
                {
                    combinationCount++;
                    int result = x1 + x2;
                    if (result==magicNum)
                    {
                       
                        Console.WriteLine($"Combination N:{combinationCount} ({x1} + {x2} = {magicNum})");
                        stop = true;
                        break;
                        
                    }
                   
                }
                if (stop == true)
                {
                    break;
                }
               
            }
           if (!stop)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNum}");
            }
        }
    }
}
