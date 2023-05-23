using System;

namespace P04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата

            //	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]

            double priceForOneKgVegetables = double.Parse(Console.ReadLine());

            //Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]

            double priceForOneKgFruits = double.Parse(Console.ReadLine());

            //Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]

            double allKgVegetables = double.Parse(Console.ReadLine());

            //Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]
            double allKgFruits = double.Parse(Console.ReadLine());

            //2 извеждаме едно число: приходите от всички плодове и зеленчуци в евро

            double sum = (priceForOneKgVegetables * allKgVegetables) + (priceForOneKgFruits * allKgFruits);

            double sumEuro = sum / 1.94;
            // 1 евро = 1.94
            Console.WriteLine($"{sumEuro:f2}");
         
        }
    }
}
