using System;

namespace P09.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationCount = 0;
            bool flag = false;

            for (int i = start; i <=stop; i++)
            {
                for (int k = start; k <=stop; k++)
                {
                    combinationCount++;
                    int result = i + k;
                    if (result==magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {k} = {magicNum})");
                        flag = true;
                        break;
                    }
                   
                }
                if (flag == true)
                {
                    break;
                }
               

            }

            if (!flag)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNum}");
            }
        }
    }
}
