using System;

namespace P06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата :
            // Първи ред – цена на скумрията на килограм. Реално число в интервала [0.00…40.00]

            double priceKilogramMackerel = double.Parse(Console.ReadLine());

            //Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]

            double priceKilogramSprinkle = double.Parse(Console.ReadLine());

            //Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]

            double kilogramOfPalamud = double.Parse(Console.ReadLine());

            //Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]

            double kilogramOfSafrid = double.Parse(Console.ReadLine());

            //Пети ред – килограма миди. Цяло число в интервала[0... 100]

            double kilogramOfMussels = double.Parse(Console.ReadLine());


            //2. Пишем цените на продуктите

            // •	Паламуд – 60% по-скъп от скумрията
            double priceKilogramPalamud = priceKilogramMackerel + priceKilogramMackerel * 0.6;
            double suMoFpalamud = kilogramOfPalamud * priceKilogramPalamud;


            //Сафрид – 80 % по - скъп от цацата

            double priceKilogramSafrid = priceKilogramSprinkle + priceKilogramSprinkle * 0.8;
            double suMoFsafrid = kilogramOfSafrid * priceKilogramSafrid;

            //Миди – 7.50 лв.за килограм

            double priceKilogramMussels = kilogramOfMussels * 7.50;


            //3. пресмятаме кйолко пари ще са нужни
            double totalSum = suMoFpalamud + suMoFsafrid + priceKilogramMussels;


            //4.Отпечатваме на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката.
            //Числото трябва да е форматирано до вторият знак след десетичната запетая (1.2457 -> 1.25).

                Console.WriteLine( $"{totalSum:F2}");

        }
    }
}
