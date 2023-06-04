using System;

namespace P03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            double priceNight = 0;

            if (destination=="France")
            {
                if (dates=="21-23")
                {
                    priceNight = night * 30;
                }
                else if (dates=="24-27")
                {
                    priceNight = night * 35;
                }
                else if (dates=="28-31")
                {
                    priceNight = night * 40;
                }


            }
          else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    priceNight = night * 28;
                }
                else if (dates == "24-27")
                {
                    priceNight = night * 32;
                }
                else if (dates == "28-31")
                {
                    priceNight = night * 39;
                }

            }

           else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    priceNight = night * 32;
                }
                else if (dates == "24-27")
                {
                    priceNight = night * 37;
                }
                else if (dates == "28-31")
                {
                    priceNight = night * 43;
                }

            }


            Console.WriteLine($"Easter trip to {destination} : {priceNight:f2} leva.");
        }
    }
}
