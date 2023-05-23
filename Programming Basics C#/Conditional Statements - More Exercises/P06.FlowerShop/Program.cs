using System;

namespace P06.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //  Брой магнолии – цяло число в интервала [0 … 50]

            int magnolias = int.Parse(Console.ReadLine());

            //Брой зюмбюли – цяло число в интервала[0 … 50]

            int hyacinths = int.Parse(Console.ReadLine());

            //Брой рози – цяло число в интервала[0 … 50]

            int rose = int.Parse(Console.ReadLine());

            // Брой кактуси – цяло число в интервала[0 … 50]

            int cactus = int.Parse(Console.ReadLine());

            //Цена на подаръка – реално число в интервала[0.00 … 500.00]

            double priceForPresent = double.Parse(Console.ReadLine());

            //2. Пресмятаме сумата от поръчката 

            double priceOrder = magnolias * 3.25 + hyacinths * 4.0 + rose * 3.50 + cactus * 8.00;


            //3 5% данък
            double totalPriceOrder = priceOrder - (priceOrder * 0.05);

            //4 Печатаме на конзолата 
            //  Ако парите СА стигнали: "She is left with {останали} leva." – сумата трябва да е закръглена към по - малко цяло число(пр. 1.90-> 1).
            if (totalPriceOrder >= priceForPresent)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalPriceOrder-priceForPresent)} leva.");
            }

            //Ако парите НЕ достигат: "She will have to borrow {останали} leva." – сумата трябва да е закръглена към по - голямо цяло число(пр. 1.10-> 2).

            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceForPresent - totalPriceOrder)} leva.");
            }
        }
    }
}
