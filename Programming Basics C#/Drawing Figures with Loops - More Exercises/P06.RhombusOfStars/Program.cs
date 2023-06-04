using System;

class RhombusOfStars
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        //First Half
        for (int i = 0; i < number; i++)
        {
            Console.Write(new string(' ', (number - 1) - i));
            Console.Write("*");

            for (int j = 0; j < i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        //Seecond Half
        for (int i = 0; i < number - 1; i++)
        {
            Console.Write(new string(' ', 1 + i));
            Console.Write("*");

            for (int j = 0; j < number - 2 - i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}