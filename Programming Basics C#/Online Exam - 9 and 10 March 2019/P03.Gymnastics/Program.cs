using System;

namespace P03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double assessment = 0;
            double remain = 0;

            if (country=="Russia")
            {
                if (device=="ribbon")
                {
                    assessment = 9.100 + 9.400;
                }
                else if (device=="hoop")
                {
                    assessment = 9.300 + 9.800;
                }
                else
                {
                    assessment = 9.600 + 9.000;
                }

            }

           else if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    assessment = 9.600 + 9.400;
                }
                else if (device == "hoop")
                {
                    assessment = 9.550 + 9.750;
                }
                else
                {
                    assessment = 9.500 + 9.400;
                }

            }

           else if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    assessment = 9.200 + 9.500;
                }
                else if (device == "hoop")
                {
                    assessment = 9.450 + 9.350;
                }
                else
                {
                    assessment = 9.700 + 9.150;
                }
            }

            remain = 20 - assessment;

            double remainToMaxPoint = (remain / 20) * 100;

            Console.WriteLine($"The team of {country} get {assessment:f3} on {device}.");
            Console.WriteLine($"{remainToMaxPoint:f2}%");
        }
    }
}
