using System;

namespace P09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата : 
            //.Дължина в см – цяло число в интервала[10 … 500]

            int length = int.Parse(Console.ReadLine());

            //Широчина в см – цяло число в интервала[10 … 300]

            int width = int.Parse(Console.ReadLine());

            //Височина в см – цяло число в интервала

            int height = int.Parse(Console.ReadLine());


            //Процент  – реално число в интервала[0.000 … 100.000]
            double percent = double.Parse(Console.ReadLine());
          

            //2 Изчисляваме обема на аквариума 
            // обем на аквариумa = дължима *широчина * височина 

            double volumeAquariumSm = length * width * height;


            //3. Изчисляваме обем в литри
            //  обем литри = обем аквариум * 0.001

            double volumeAquariumLiters = volumeAquariumSm * 0.001;

            //4.заето място
            double occupiedVolume = percent * 0.01;


            //5. нужни литри 
            //нужни литри= обем в литри  * (1 -заето пространство)

            double totalVolumeLittersAquarium = volumeAquariumLiters * (1 - occupiedVolume);


            //6 Печатаме на конзолата нужни литри
            Console.WriteLine(totalVolumeLittersAquarium);
        }
    }
}
