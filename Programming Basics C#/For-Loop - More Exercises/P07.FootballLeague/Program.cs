using System;

namespace P07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int numFens = int.Parse(Console.ReadLine());

            int fensSectorA = 0;
            int fensSectorB = 0;
            int fensSectorV = 0;
            int fensSectorG = 0;


            for (int i =1; i<= numFens; i++ )
            {
                char sector = char.Parse (Console.ReadLine());

                if (sector=='A')
                {
                    fensSectorA++;
                }
                else if (sector=='B')
                {
                    fensSectorB++;
                }
                else if (sector=='V')
                {
                    fensSectorV++;
                }
                else
                {
                    fensSectorG++;
                }

            }
            double procentAllFens = ((double)numFens / stadiumCapacity) * 100;

            Console.WriteLine($"{((double)fensSectorA/numFens)*100:f2}%");
            Console.WriteLine($"{((double) fensSectorB/numFens)*100:f2}%");
            Console.WriteLine($"{((double) fensSectorV/numFens)*100:f2}%");
            Console.WriteLine($"{((double) fensSectorG/numFens)*100:f2}%");
            Console.WriteLine($"{procentAllFens:f2}%");

        }
    }
}
