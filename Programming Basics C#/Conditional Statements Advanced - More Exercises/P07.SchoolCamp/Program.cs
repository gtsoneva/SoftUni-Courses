using System;

namespace P07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNight = int.Parse(Console.ReadLine());


            double priceNight = 0;
            string sport = string.Empty;

            if (season=="Winter")
            {
                if (groupType=="girls" || groupType == "boys")
                {
                    priceNight = numStudents *9.60;
                }
                else
                {
                    priceNight = numStudents * 10;
                }

                if (groupType=="girls")
                {
                    sport = "Gymnastics";
                }
                else if (groupType=="boys")
                {
                    sport = "Judo";
                }
                else
                {
                    sport = "Ski";
                }

            }
            if (season == "Spring")
            {
                if (groupType == "girls" || groupType == "boys")
                {
                    priceNight = numStudents * 7.20;
                }
                else
                {
                    priceNight = numStudents * 9.50;
                }

                if (groupType == "girls")
                {
                    sport = "Athletics";
                }
                else if (groupType == "boys")
                {
                    sport = "Tennis";
                }
                else
                {
                    sport = "Cycling";
                }
            }

            if (season == "Summer")
            {
                if (groupType == "girls" || groupType == "boys")
                {
                    priceNight = numStudents * 15;
                }
                else
                {
                    priceNight = numStudents * 20;
                }

                if (groupType == "girls")
                {
                    sport = "Volleyball";
                }
                else if (groupType == "boys")
                {
                    sport = "Football";
                }
                else
                {
                    sport = "Swimming";
                }

            }

            if (numStudents >= 50)
            {
                priceNight = priceNight - priceNight * 0.50;
            }
            else if (numStudents >= 20 && numStudents < 50)
            {
                priceNight = priceNight - priceNight * 0.15;
            }
            else if (numStudents >= 10 && numStudents < 20)
            {
                priceNight = priceNight - priceNight * 0.05;
            }
            else
            {
                priceNight = priceNight;
            }

            double totalPrice = priceNight * numNight;
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
