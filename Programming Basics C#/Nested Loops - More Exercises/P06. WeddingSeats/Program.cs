using System;

namespace P06._WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int nonPrimeSeats = int.Parse(Console.ReadLine());
            int seatscounter = 0;
            

            for (char i = 'A'; i <=lastSector ; i++)
            {
                rows = rows+ 1;
                for (int k = 1; k < rows; k++)
                {
                    if (k % 2 != 0)
                    {
                        seatscounter += nonPrimeSeats;

                        for (char j = 'a'; j <='a' + nonPrimeSeats - 1; j++)
                        {

                            Console.WriteLine($"{i}{k}{j}");
                        }
                    }
                    else
                    {
                        seatscounter += nonPrimeSeats + 2;
                        for(char j = 'a'; j <='a' + nonPrimeSeats + 1; j++)
                        {
                            Console.WriteLine($"{i}{k}{j}");
                        }
                    }
                }
            }
            Console.WriteLine(seatscounter);
        }
    }
}
