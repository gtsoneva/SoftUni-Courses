using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            double kmFirstDay = double.Parse(Console.ReadLine());

            double all = kmFirstDay;

            for (int i = 0; i <countDays; i++)
            {
                double procent = double.Parse(Console.ReadLine());

                kmFirstDay = kmFirstDay + (kmFirstDay * (procent / 100));
                all += kmFirstDay;
               

            }

            if (all>=1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(all-1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000-all)} more kilometers");
            }
        }
    }
}
