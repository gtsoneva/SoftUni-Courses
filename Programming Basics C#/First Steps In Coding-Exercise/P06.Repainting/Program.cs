using System;

namespace P06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.	Необходимо количество найлон (в кв.м.) - double + 2

            int naylonQuantity = int.Parse(Console.ReadLine()) + 2 ;
            //Необходимо количество боя(в литри) - double + 10
            double paintLiters = double.Parse(Console.ReadLine());
            paintLiters = paintLiters + paintLiters * 0.1;


            //Количество разредител(в литри) - цяло число в интервала[1…30] 

            int thinnerLiters = int.Parse(Console.ReadLine());

            //Часовете, за които майсторите ще свършат работата -int
            int workTime = int.Parse(Console.ReadLine());


            //2 Пишем цената на материалите 
            //•	Предпазен найлон - 1.50 лв. за кв. метър
            double naylonPrice = naylonQuantity * 1.5;

            //Боя - 14.50 лв.за литър
            double paintPrice = paintLiters * 14.50;

            //Разредител за боя - 5.00 лв.за литър  

            double thinnerPrice = thinnerLiters * 5.00;


            //3.общата сума на материалите 
            double materials = naylonPrice + paintPrice + thinnerPrice + 0.4;


            //4  Сумата, която се заплаща на майсторите за 1 час работа
            // 30%  от сбора на всички разходи
            double workPrice = materials * 0.3;
            //5.Намираме колко ще излезе ремонта 
            //общата сума + цената за час работа 
            double totalSum = materials + workPrice * workTime;
            //5 Отпечатваме на конзолата крайната сума за материалите



            Console.WriteLine(totalSum);
        }
    }
}
