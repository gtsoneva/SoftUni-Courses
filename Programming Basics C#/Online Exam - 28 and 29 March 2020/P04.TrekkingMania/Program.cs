using System;

namespace P04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());

            int countMusala = 0;
            int countMonblan = 0;
            int countKilimandjaro = 0;
            int countK2 = 0;
            int countEverest = 0;
            double totalPeople = 0;

            for (int i = 1; i <=group; i++)
            {
                int people = int.Parse(Console.ReadLine());
                totalPeople += people;
                if (people <= 5)
                {
                    countMusala+=people;
                }
                else if ( people>=6 && people <= 12)
                {
                    countMonblan+=people;
                }
                else if ( people>=13 && people <= 25)
                {
                    countKilimandjaro+=people;
                }
                else if (people >=26 && people<=40)
                {
                    countK2+=people;
                }
                else
                {
                    countEverest += people;
                }

            }

            Console.WriteLine($"{(countMusala/totalPeople)*100:f2}%");
            Console.WriteLine($"{(countMonblan/totalPeople)*100:f2}%");
            Console.WriteLine($"{(countKilimandjaro / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(countK2 / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(countEverest / totalPeople) * 100:f2}%");
        }
    }
}
