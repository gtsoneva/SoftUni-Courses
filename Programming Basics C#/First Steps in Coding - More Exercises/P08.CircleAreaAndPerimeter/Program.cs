using System;

namespace P08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius =  double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double parameter = 2 * Math.PI * radius;


            Console.WriteLine($"{ area:f2}");
            Console.WriteLine($"{ parameter:f2}");

        }
    }
}
