using System;

namespace P02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            int combination = 0;

            for (char i = first; i <= second; i++)
            {
                for (char k = first; k <=second; k++)
                {
                    for (char j = first; j <=second; j++)
                    {

                        if (i != third && j != third && k != third)
                        {
                            Console.Write($"{i}{k}{j} ");
                            combination++;
                        }
                       
                    }
                }
            }
            Console.Write(combination + " ");

        }
    }
}
