using System;

namespace P06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double pointAcademy = double.Parse(Console.ReadLine());
            int numJury = int.Parse(Console.ReadLine());


            double sumPoints = pointAcademy;
            
            for (int i = 0; i< numJury; i++)
            {
                string nameJury = Console.ReadLine();
                double pointJury = double.Parse(Console.ReadLine());
                double momentPoint = (nameJury.Length * pointJury) / 2;
                sumPoints = sumPoints + momentPoint;


                if (sumPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {sumPoints:f1}!");
                    break;
                }
              
            }
            if (sumPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameActor} you need {1250.5 - sumPoints:f1} more!");
            }
        }
    }
}
