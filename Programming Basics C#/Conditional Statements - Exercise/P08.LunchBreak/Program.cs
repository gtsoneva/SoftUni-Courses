using System;

namespace P08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //Име на сериал – текст

            string seriesName = Console.ReadLine();

            //Продължителност на епизод  – цяло число в диапазона[10… 90]

            int seriesTime = int.Parse(Console.ReadLine());

            //.Продължителност на почивката  – цяло число в диапазона[10… 120]

            int lunchTime = int.Parse(Console.ReadLine());
            //обедна почивка- (време за обяд + време за отдих)
            //8/8-(1/8 за обяд + 1/4 за почивка)
            //8/8-(1/8+2/8)
            //8/8-3/8
            // имаме => 5/8 от обедната почивка за сериала

            double timeForSeries = (double)lunchTime * 5 / 8;
             

           

            //5 Печатаме на конзолата 
            // Времето да се закръгли до най-близкото цяло число нагоре.
            // •	Ако времето е достатъчно да изгледате епизода: "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."

            if (timeForSeries >= seriesTime)
            {
                Console.WriteLine($"You have enough time to watch { seriesName } and left with {Math.Ceiling(timeForSeries-seriesTime)} minutes free time.");
            }
            // •	Ако времето не Ви е достатъчно: "You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."

            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime-timeForSeries)} more minutes.");
            }


        }
    }
}
