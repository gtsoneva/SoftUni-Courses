using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int countNight = int.Parse(Console.ReadLine());
            int countCardTransport = int.Parse(Console.ReadLine());
            int countTicket = int.Parse(Console.ReadLine());

           int nightForOnePeople = countNight*20;
            double cardTransport = countCardTransport*1.60;
            int oneTicket = countTicket*6;

            double sumForOnePeople = nightForOnePeople + cardTransport + oneTicket;

            double sumAll = sumForOnePeople * countPeople;
            double totalSumAll = sumAll + (sumAll * 0.25);

            Console.WriteLine($"{totalSumAll:f2}");


        }
    }
}
