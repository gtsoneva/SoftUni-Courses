using System;

namespace P08.SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHundreds = int.Parse(Console.ReadLine());
            int maxDozens = int.Parse(Console.ReadLine());
            int maxUnits = int.Parse(Console.ReadLine());

            for (int i = 2; i <= maxHundreds; i += 2)
            {
                for (int k = 2; k <= maxDozens; k++)
                {
                    for (int j = 2; j <= maxUnits; j += 2)
                    {
                        if (k == 2 || k == 3 || k == 5 || k == 7)
                        {
                            Console.WriteLine(i + " " + k + " " + j);
                        }
                    }
                }
            }
        }    
    }
}
