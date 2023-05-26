using System;

namespace P05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            string site;
            for (int tab =1; tab<=openTabs; tab++ )
            {
                site = Console.ReadLine();

                if (site=="Facebook")
                {
                    salary = salary - 150;
                }
                else if (site=="Instagram")
                {
                salary -= 100;
                }
            else if (site =="Reddit")
                  {
                salary -= 50;
                  }

                if (salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary>0)
            {
                Console.WriteLine($"{salary}");
            }

        }
    }
}
