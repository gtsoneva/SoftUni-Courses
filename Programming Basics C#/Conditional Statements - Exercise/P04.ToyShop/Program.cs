using System;

namespace P04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //Цена на екскурзията -реално число в интервала[1.00 … 10000.00]

            double priceExcursion = double.Parse(Console.ReadLine());

            //Брой пъзели - цяло число в интервала[0… 1000]

            int puzzles = int.Parse(Console.ReadLine());

            //Брой говорещи кукли -цяло число в интервала[0 … 1000]

            int dolls = int.Parse(Console.ReadLine());

            //Брой плюшени мечета -цяло число в интервала[0 … 1000]

            int bears = int.Parse(Console.ReadLine());

            //Брой миньони - цяло число в интервала[0 … 1000]

            int minions = int.Parse(Console.ReadLine());

            //Брой камиончета - цяло число в интервала[0 … 1000]

            int trucks = int.Parse(Console.ReadLine());
            //3.Намираме общия брой поръчани играчки
            int toysQuantity = puzzles + dolls + bears + minions + trucks;
            //3. Намираме цена на поръчка 

            //Пъзел - 2.60 лв.
           //Говореща кукла -3 лв.
            //Плюшено мече -4.10 лв.
          //Миньон - 8.20 лв.
            //Камионче - 2 лв.

            double money= puzzles*2.60 + dolls*3 + bears*4.10 + minions*8.20 + trucks*2;
            //3. Играчките ако са >=50 отстъпка 25%

            if (toysQuantity >= 50)
            {
                //money-=money*0.25
                money = money-money * 0.25;
            
            }

            //4. Наем 10% на магазина

            money = money - money * 0.10;

            if (money >= priceExcursion)
            {
                Console.WriteLine($"Yes! {money - priceExcursion:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceExcursion - money:F2} lv needed.");
            }

  

                //5. Отпечатваме на конзолата 
                //Ако парите са достатъчни се отпечатва: "Yes! {оставащите пари} lv left."
                //Ако парите НЕ са достатъчни се отпечатва: "Not enough money! {недостигащите пари} lv needed."



            }
    }
}
