using System;

namespace P05.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата
            //•	Първи ред – брой дни – цяло число в интервал [1…5000]
            int days = int.Parse(Console.ReadLine());

            //Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]

           double foodLeft = int.Parse(Console.ReadLine());

            //Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]

            double foodForDogPerDay = double.Parse(Console.ReadLine());

            //Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]

            double foodForCatPerDay = double.Parse(Console.ReadLine());
            //Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]

            double foodForTurtlePerDay = double.Parse(Console.ReadLine());
            
            //2. Изчисляваме колко храна е нужна на животните 

            double food = foodForDogPerDay * days + foodForCatPerDay * days + (foodForTurtlePerDay/1000) * days;

            //3. Проверяваме дали оставената храна е достатъчна 

            if (food<= foodLeft)
            {

                Console.WriteLine($"{Math.Floor(foodLeft-food)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(food-foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
