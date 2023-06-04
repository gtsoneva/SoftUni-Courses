using System;

namespace P04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());
            int ticket = 5;
            double sum = 0;
            double income = 0;
            int seats = 0;
            int countPeople = 0;
            string input = Console.ReadLine();

            while (input!="Movie time!")
            {
                countPeople = int.Parse(input);
                

                
                if (countPeople%3==0)
                {
                    sum = (ticket * countPeople) - 5;
                }
                else
                {
                    sum = ticket * countPeople;
                }
       

                
                seats += countPeople;
                if (seats > hallCapacity)
                {

                    break;
                }
                income += sum;
                

                input = Console.ReadLine();
                if (input == "Movie time!")
                {

                    break;
                }

            }
            if (input == "Movie time!" )
            {
                Console.WriteLine($"There are {Math.Abs(seats - hallCapacity)} seats left in the cinema.");

            }
          else  if (seats >= hallCapacity)
            {
                Console.WriteLine($"The cinema is full.");
               
            }

   

            
            Console.WriteLine($"Cinema income - {income} lv.");
            
        }
    }
}