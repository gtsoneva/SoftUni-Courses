﻿using System;

namespace P04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int pow=0; pow<=n; pow+=2)
            {
                Console.WriteLine(Math.Pow(2, pow));
            }
        }
    }
}
