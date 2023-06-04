using System;

namespace P04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();

            int countFired = 0;
            int countNotFired = 0;
            int totalPoins = 301;

            while (totalPoins != 0)
            {
                string shot = Console.ReadLine();



                if (shot == "Retire")
                {
                    Console.WriteLine($"{namePlayer} retired after {countNotFired} unsuccessful shots.");
                    break;
                }
                int points = int.Parse(Console.ReadLine());

                if (shot == "Single")
                {
                    if (points <= totalPoins && totalPoins > 0)
                    {
                        totalPoins -= points;
                        countFired++;
                    }
                    else
                    {
                        countNotFired++;
                    }

                }
                if (shot == "Double")
                {
                    points *= 2;
                    if (points <= totalPoins && totalPoins > 0)
                    {
                        totalPoins -= points;
                        countFired++;
                    }
                    else
                    {
                        countNotFired++;
                    }
                }
                if (shot == "Triple")
                {
                    points *= 3;
                    if (points <= totalPoins && totalPoins > 0)
                    {
                        totalPoins -= points;
                        countFired++;
                    }
                    else
                    {
                        countNotFired++;
                    }
                }
                if (totalPoins == 0)
                {
                    Console.WriteLine($"{namePlayer} won the leg with {countFired} shots.");
                    break;
                }
            }





        }
           
    }
}
