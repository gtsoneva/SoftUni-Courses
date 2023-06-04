using System;

namespace P01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuettes = rent - (rent * 0.3);
            double catering = statuettes - (statuettes * 0.15);
            double voicing = catering / 2;
            double totalPrice = rent + statuettes + catering + voicing;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
