using System;

namespace P13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startFirst = int.Parse(Console.ReadLine());
            int startSecond = int.Parse(Console.ReadLine());
            int differenceFirst = int.Parse(Console.ReadLine());
            int differenceSecond = int.Parse(Console.ReadLine());
            

            int maxA = startFirst + differenceFirst;
            int maxB = startSecond + differenceSecond;

            for (int i = startFirst; i <= maxA; i++)
            {  
                    for (int l = startSecond; l <=maxB; l++)
                    {
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && l % 2 != 0 && l % 3 != 0 && l % 5 != 0 && l % 7 != 0)
                    {
                        Console.WriteLine($"{i}{l}");
                        
                    }


                    }

            }


        }
    }
}




