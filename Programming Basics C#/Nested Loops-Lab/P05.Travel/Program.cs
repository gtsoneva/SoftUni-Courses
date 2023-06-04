using System;

namespace P05.Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();
            string destination;
           double budget;
           
              
            while (input!="End")

            {

                destination = input;
                budget = double.Parse(Console.ReadLine());

                while(budget>0)
                {
                    budget -= double.Parse(Console.ReadLine());

                }

                Console.WriteLine($"Going to {destination}!");
                input = Console.ReadLine();
            }

          
        }
    }
}
