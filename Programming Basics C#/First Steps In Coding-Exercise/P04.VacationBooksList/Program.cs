using System;

namespace P04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int page = int.Parse(Console.ReadLine());
            int pagePerHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int allHours = page / pagePerHours;
            int hoursPerDay = allHours / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
