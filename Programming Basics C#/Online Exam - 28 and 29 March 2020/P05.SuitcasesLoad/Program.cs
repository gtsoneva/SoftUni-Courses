using System;

namespace P05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int countSuitcase = 0;
            int loadedSuitcase = 0;

            while (input!="End")
            {
                countSuitcase++;
                double suitcaseVolume = double.Parse(input);

                if (input == "End")
                {
                   
                    break;
                }
               
                if (countSuitcase % 3 == 0)
                {
                    suitcaseVolume += suitcaseVolume * 0.1;
                }
                if (trunkCapacity < suitcaseVolume)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                trunkCapacity -= suitcaseVolume;
                loadedSuitcase++;

              

                input = Console.ReadLine();
               
            }
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

                Console.WriteLine($"Statistic: {loadedSuitcase} suitcases loaded.");
        }
    }
}
