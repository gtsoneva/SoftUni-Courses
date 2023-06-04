using System;

namespace P05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());

            int countBack = 0;
            int countChest = 0;
            int countLegs = 0;
            int countAbs = 0;
            int countWorkOut = 0;
            int countProtein = 0;
            int countBuyProteinShake = 0;
            int countBuyProteinBar = 0;
            


            for (int i = 1; i <=countPeople ; i++)
            {
                string activity = Console.ReadLine();

                if (activity=="Back")
                {
                    countBack++;
                    countWorkOut++;
                }
                else if (activity=="Chest")
                {
                    countChest++;
                    countWorkOut++;
                }
                else if (activity=="Legs")
                {
                    countLegs++;
                    countWorkOut++;

                }
                else if (activity=="Abs")
                {
                    countAbs++;
                    countWorkOut++;
                }
                else if (activity=="Protein shake")
                {
                    countBuyProteinShake++;
                    countProtein++;
                }
                else if (activity=="Protein bar")
                {
                    countBuyProteinBar++;
                    countProtein++;
                }

                
            }
            Console.WriteLine($"{countBack} - back");
            Console.WriteLine($"{countChest} - chest");
            Console.WriteLine($"{countLegs} - legs");
            Console.WriteLine($"{countAbs} - abs");
            Console.WriteLine($"{countBuyProteinShake} - protein shake");
            Console.WriteLine($"{countBuyProteinBar} - protein bar");
            Console.WriteLine($"{((double)countWorkOut/countPeople*100):f2}% - work out");
            Console.WriteLine($"{((double)countProtein/countPeople*100):f2}% - protein");

        }
    }
}
