using System;

namespace P03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLoads = int.Parse(Console.ReadLine());


            double loadVan = 0;
            double loadTruck = 0;
            double loadTrain = 0;
            double allLoads = 0;

            for (int i=1; i<=numLoads;i++)
            {
                int tonLoads = int.Parse(Console.ReadLine());

                if (tonLoads<=3)
                {

                    loadVan += tonLoads;
                    
                }
                else if (tonLoads>=4 && tonLoads <=11)
                {
                    loadTruck += tonLoads;
                }
                else
                {
                    loadTrain += tonLoads;
                }

                allLoads += tonLoads;
            }

            double averagePerTon = (loadVan * 200 + loadTruck * 175 + loadTrain * 120) / allLoads;

            Console.WriteLine($"{averagePerTon:f2}");
            Console.WriteLine($"{loadVan / allLoads * 100:f2}% ");
            Console.WriteLine($"{loadTruck / allLoads * 100:f2}% ");
            Console.WriteLine($"{loadTrain / allLoads * 100:f2}% ");
        }
    }
}
