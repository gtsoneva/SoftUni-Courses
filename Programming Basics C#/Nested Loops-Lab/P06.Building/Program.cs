using System;

namespace P06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFloors = int.Parse(Console.ReadLine());
            int roomsForOneFloor = int.Parse(Console.ReadLine());

            for(int i = countFloors; i >0; i--)
            {
                for (int j = 0; j < roomsForOneFloor; j++)
                {
                    if (i==countFloors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                  else if (i%2==0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
          
        }
    }
}
