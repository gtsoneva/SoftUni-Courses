﻿using System;

namespace P02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
          
            for (int num = firstNum; num <= secondNum; num++)
            {
                int evenSum = 0;
                int oddSum=0;
                string currentNum = num.ToString();
                for (int i = 0; i <6; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += currentNum[i];
                    }
                    else
                    {
                        oddSum += currentNum[i];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{num} ");
                }
            }
           

        }
    }
}
