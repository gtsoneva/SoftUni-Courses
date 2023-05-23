using System;

namespace P07.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата
            //на първия ред се чете типа на горивото – текст с възможности: "Diesel", "Gasoline" или "Gas",
            //а на втория литрите гориво, които има в резервоара. 
            string typeFuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());

            if (typeFuel=="Diesel")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }

           else if (typeFuel == "Gasoline")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
            }

           else if (typeFuel == "Gas")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }




        }
    }
}
