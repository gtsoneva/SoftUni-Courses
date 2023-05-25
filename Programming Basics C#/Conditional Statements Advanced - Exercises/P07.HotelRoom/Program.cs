using System;

namespace P07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNight = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

          if (month== "May" || month== "October")
            {
                priceStudio = 50;
                priceApartment = 65;
            }
          else if (month=="June"||month=="September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;
            }
          else
            {
                priceStudio = 76;
                priceApartment = 77;
                if  (numNight > 14)
                {
                    priceApartment = priceApartment - priceApartment * 0.1;
                }
            }

          if (numNight>7 && numNight<=13 && (month== "May" || month== "October"))
            {
                priceStudio = priceStudio - priceStudio * 0.05;
            }
          else if (numNight > 14 && (month == "May" || month == "October"))
            {
                priceStudio =  priceStudio - priceStudio * 0.3;
                priceApartment = priceApartment - priceApartment * 0.1;
            }
          else if (numNight > 14 &&( month == "June" || month == "September"))
            {
                priceStudio = priceStudio- priceStudio * 0.2;
                priceApartment = priceApartment - priceApartment * 0.1;
            }



            Console.WriteLine($"Apartment: {priceApartment*numNight:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio*numNight:f2} lv.");
        }
    }
}
