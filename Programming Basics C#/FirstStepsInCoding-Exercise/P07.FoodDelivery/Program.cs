using System;

namespace P07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем на конзолата: 
                         // •	Брой пилешки менюта – цяло число в интервала [0 … 99]
            double chickenMenu = double.Parse(Console.ReadLine());

            //Брой менюта с риба – цяло число в интервала[0 … 99]
            //
            double fishMenu = double.Parse(Console.ReadLine());

            //Брой вегетариански менюта – цяло число в интервала[0 … 99]

            double vegetarianMenu = double.Parse(Console.ReadLine());

            //2 Пишем цената на продуктите: 

            //•	Пилешко меню –  10.35 лв. 

                double chickenPrice =  chickenMenu * 10.35;

            //Меню с риба – 12.40 лв.

            double fishPrice=  fishMenu * 12.40;

            //Вегетарианско меню  – 8.15 лв.

            double vegetarianPrice= vegetarianMenu * 8.15;


            //3. Обща цена на менютата
            // Пилешко меню + Меню с риба + вегетарианско меню 

            double totalPriceMenu = chickenPrice + fishPrice + vegetarianPrice;

            //4 Цена на десерта: 20% от общата цена на менютата

            double dessert = totalPriceMenu * 0.2;

            //5 Цена на доставка 2.50 

            //6 Обща цена на поръчката 
            // обща цена на менютата + цена десерт + цена доставка 

            double totalSum = totalPriceMenu + dessert + 2.50;


            //7 Да се отпечата на конзолата цена на поръчката 

            Console.WriteLine(totalSum);





        }
    }
}
