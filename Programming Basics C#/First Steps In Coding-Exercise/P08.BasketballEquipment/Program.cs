using System;

namespace P08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 • Четем от конзолата 
            //	Годишната такса за тренировки по баскетбол – цяло число в интервала [0… 9999] 
            double yearTax = double.Parse(Console.ReadLine());


            //2     Намираме цена за кецовете 
            //Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            double shoesPrice = yearTax - yearTax * 0.4;


            //3 Намираме цена на екип 

            //•	Баскетболен екип – цената му е 20% по-евтина от тази на кецовете

            double outfitPrice = shoesPrice - shoesPrice * 0.2;


            //4 Намираме цена на топка
            //Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            double ballPrice = outfitPrice / 4;


            //5 Намираме цена на аксесоари
            //	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
            double accessoriesPrice = ballPrice / 5;


            //6 обща цена на екипировката 
            double totalSum = yearTax + shoesPrice + outfitPrice + ballPrice + accessoriesPrice;

            //7.Печатаме на конзолата общата цена на екипировката

            Console.WriteLine(totalSum);
        }
    }
}
