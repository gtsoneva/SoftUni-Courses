using System;

namespace P03.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата 
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            //2 Правим часовете на минути
            min = min + hours * 60;

            //3 добавяме 15 минути
            min = min + 15;

            //4 Обръщаме минутите в часове + минути
            hours = min / 60;
            min = min % 60;

            if (hours == 24)
                {
                hours = 0;
            }

            //5 Печатаме на конзолата 
            
            Console.WriteLine($"{hours}:{min:D2}");
        }
    }
}
