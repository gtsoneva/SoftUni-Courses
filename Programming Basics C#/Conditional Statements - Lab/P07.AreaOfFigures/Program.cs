﻿using System;

namespace P07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = (Console.ReadLine());
            double area = 0;
            if (figureType == "square")
            {
                double sideLength = double.Parse(Console.ReadLine());
                area = sideLength * sideLength;
            }
            else if (figureType == "rectangle")
            {
                double sideLength1 = double.Parse(Console.ReadLine());
                double sideLenght2 = double.Parse(Console.ReadLine());
               area = sideLength1 * sideLenght2;
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;

            }
            else if (figureType == "triangle")
                 {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
            }
            Console.WriteLine($"{area:f3}");

        }
    }
}



