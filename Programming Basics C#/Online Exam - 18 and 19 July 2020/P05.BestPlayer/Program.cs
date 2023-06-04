using System;

namespace P05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string bestPlayer = " ";
            int maxGoals = 0;
            

            while (input!="END")
            {
                if (input=="END")
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());

                

                if (goals>maxGoals)
                {
                    bestPlayer = input;
                    maxGoals = goals;
                }
                if (goals >= 10)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"{bestPlayer} is the best player!");
           if (maxGoals>=3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
           else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
