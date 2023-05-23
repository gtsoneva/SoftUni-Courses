using System;

namespace P06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //	Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            double wordRecord= double.Parse(Console.ReadLine());

            //Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double distance = double.Parse(Console.ReadLine());

            //Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            double timePerMeter = double.Parse(Console.ReadLine());



            //3.Добавяме съпротивлението .Колко ще се забави на всеки 15 метра с 12.5сек
            double delay = Math.Floor(distance / 15)*12.5;


            //2  Пресмятаме колко време му е нужно за да преплува 
            double recordByIvan = distance * timePerMeter + delay;
            
            if (recordByIvan < wordRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(wordRecord-recordByIvan):f2} seconds slower.");
            }
        }
    }
}
