using System;

namespace P05.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
             //1. Четем от конзолата
                      //	Брой пакети химикали - цяло число в интервала [0...100]
                      //Брой пакети маркери - цяло число в интервала[0...100]
                      //Литри препарат за почистване на дъска -цяло число в интервала[0…50]
                      //Процент намаление -цяло число в интервала[0...100]

            int pacetPen = int.Parse(Console.ReadLine());
            int pacetMarker = int.Parse(Console.ReadLine());
            int preparationLiters = int.Parse(Console.ReadLine());
            int discoint = int.Parse(Console.ReadLine());
            //2. Пишем цената на материалите 
            //	Пакет химикали -5.80 лв.
            //Пакет маркери -7.20 лв.
            //Препарат - 1.20 лв(за литър)

            double penPrice = pacetPen* 5.80;
            double markerPrice = pacetMarker * 7.20;
            double preparationPrice = preparationLiters * 1.20;



            // 3. Намираме общата сума
            double sum = penPrice + markerPrice + preparationPrice;

            //4. Намираме сумата с отстъпката
            double totalSum = sum - (sum *discoint/100);
            // 5. Извеждаме на конзолата
            Console.WriteLine(totalSum);
        }
    }
}
