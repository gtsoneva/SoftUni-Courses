﻿using System;

namespace P07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i =0; i< n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

            }

            Console.WriteLine(sum);
        }
    }
}
