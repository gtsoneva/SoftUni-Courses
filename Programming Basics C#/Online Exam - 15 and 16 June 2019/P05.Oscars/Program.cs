using System;

namespace P05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double pointAcademy = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            double totalPoint = 0;

            for (int i = 1; i <= jury; i++)
            {
                string nameJury = Console.ReadLine();
                double pointJury = double.Parse(Console.ReadLine());

                double point = 0;

                 point = (nameJury.Length * pointJury) / 2;

                totalPoint += point;

                if ((totalPoint + pointAcademy) > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {(totalPoint + pointAcademy):f1}!");
                    break;
                }
            }
            
            
            if ((totalPoint+pointAcademy) < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameActor} you need {1250.5 - (totalPoint+pointAcademy):f1} more!");
            }
        }
    }
}
