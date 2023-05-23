using System;

namespace P02._SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //едно число – броят почивни дни – цяло число в интервала [0...365]
            int numHoliday = int.Parse(Console.ReadLine());


            //2 За да се наспи добре нормата на Том е 30 000  минути в година. 
            //Времето за игра на Том зависи от почивните дни на стопанина му:
            //Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //Когато почива, стопанинът му си играе с него по 127 минути на ден.
            int holidayMinPlay = numHoliday * 127;
            int workDayMinPlay = (365 - numHoliday) * 63;
            int allDayPlay = holidayMinPlay + workDayMinPlay;

            //3. Печатаме на конзолата 
            //•	Ако времето за игра на Том е над нормата за текущата година:
            //На първия ред отпечатайте: “Tom will run away”
            //На втория ред отпечатайте разликата от нормата във формат:“{ H}hours and { M} minutes more for play”
            if (allDayPlay<30000)
            {
                int minToLessPlay = 30000 - allDayPlay;
                int H = minToLessPlay / 60;
                int M = minToLessPlay % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{H} hours and {M} minutes less for play");
            }

            // •	Ако времето за игра на Том е под нормата за текущата година:
            //На първия ред отпечатайте: “Tom sleeps well”
            // На втория ред отпечатайте разликата от нормата във формат:“{ H}hours and { M} minutes less for play”
            else 
            {
                int minToMorePlay = allDayPlay - 30000;
                int H = minToMorePlay / 60;
                int M = minToMorePlay % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{H} hours and { M} minutes more for play");
            }

        }
    }
}
