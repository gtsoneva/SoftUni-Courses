using System;

namespace P09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string assessment = Console.ReadLine();

            int night = dayStay - 1;
            double price = 0.0;
            if (roomType== "room for one person")
            {
                price = night * 18;
            }
            else if (roomType== "apartment")
            {
                price = night * 25;
                if (dayStay < 10)
                {
                    price= price - price * 0.3;
                }
                else if (dayStay >= 10 && dayStay <= 15)
                {
                    price = price-price* 0.35;
                }
                else 
                {
                    price=  price - price * 0.5;
                }
            }

            else
            {
                price = night * 35;

                if (dayStay<10)
                {
                    price =  price - price * 0.1;
                }
                else if(dayStay>=10 && dayStay <=15)
                {
                    price = price - price * 0.15;
                }
                else
                {
                    price = price - price * 0.2;
                }
            }

            if (assessment=="positive")
            {
                price =price + price * 0.25;
            }
            else
            {
                price=price-price* 0.10;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
