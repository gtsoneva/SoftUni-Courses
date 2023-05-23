using System;

namespace P09.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
           double gradus= double.Parse(Console.ReadLine());
            if (gradus >= 26.00 && gradus <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (gradus >= 20.1 && gradus <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (gradus >= 15.00 && gradus <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (gradus > 12.00 && gradus <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (gradus >= 5.00 && gradus <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
                Console.WriteLine("unknown");
        }
    }
}
