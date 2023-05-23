using System;

namespace P05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата
            //w(дължина в метри) 
            //h(широчина в метри).
            double hallHeight = double.Parse(Console.ReadLine()) * 100;
            double hallWidth = (double.Parse(Console.ReadLine()) * 100) - 100;

            int wWorkingPlaces = (int)hallWidth / 70;
            int hWorkingPlaces = (int)hallHeight / 120;

            int hallWorkingPlaces = (wWorkingPlaces * hWorkingPlaces) - 3;

            Console.WriteLine(hallWorkingPlaces);

        }

    }

}