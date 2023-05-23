using System;

namespace P03.CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesCelsius = double.Parse(Console.ReadLine());
            double degreesFahrenheit = degreesCelsius * 9 / 5 + 32;

            Console.WriteLine($"{degreesFahrenheit:f2}");
        }
    }
}
