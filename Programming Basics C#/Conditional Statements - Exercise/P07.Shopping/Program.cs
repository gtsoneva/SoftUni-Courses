using System;

namespace P07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата 
            //Бюджетът на Петър - реално число в интервала [0.0…100000.0]

            double budget = double.Parse(Console.ReadLine());

            //Броят видеокарти - цяло число в интервала[0…100]

            int numVideocard = int.Parse(Console.ReadLine());

            //Броят процесори - цяло число в интервала[0…100]

            int processors = int.Parse(Console.ReadLine());

            //Броят рам памет -цяло число в интервала[0…100]

            int ramMemory = int.Parse(Console.ReadLine());


            //2. Пишем цените 
            //•	Видеокарта – 250 лв./бр.

            double priceVideocard = numVideocard * 250;

            //Процесор – 35 % от цената на закупените видеокарти/ бр.

            double priceProcessors = processors *(priceVideocard * 0.35);
            

            //Рам памет – 10 % от цената на закупените видеокарти/ бр.
            double priceRamMemory = priceVideocard *0.10;
            double sumRamMemory = ramMemory * priceRamMemory;
            
            //4. Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.

            double sum = priceVideocard + priceProcessors + sumRamMemory;
            
            //3. Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от крайната сметка. 
            if (numVideocard>processors)
            {
                sum -= sum * 0.15;
            }
           
           
            
            //5. Печатаме на конзолата 
            //•	Ако бюджета е достатъчен:"You have {остатъчен бюджет} leva left!"

            if (sum<= budget)
            {
                double result = budget - (sum);
                Console.WriteLine($"You have {result:f2} leva left!");
            }

            //Ако сумата надхвърля бюджета:"Not enough money! You need {нужна сума} leva more!"
            else
            {
                double result = (sum) - budget;
                Console.WriteLine($"Not enough money! You need {result:f2} leva more!");
            }
          

        }
    }
}
