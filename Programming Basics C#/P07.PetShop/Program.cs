using System;

namespace P07.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int pacetDog = int.Parse(Console.ReadLine());
            int pacetCat = int.Parse(Console.ReadLine());
            double foodDog = (2.50 * pacetDog);
            double foodCat = (4 * pacetCat);
            double finalPrice = foodDog + foodCat;

            Console.WriteLine($"{finalPrice} lv.");


        }
    }
}