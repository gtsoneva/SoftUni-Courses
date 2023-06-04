using System;

namespace P07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int wholeSpace = width * length * height;
            while (wholeSpace>=0)
            {
             string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{wholeSpace} Cubic meters left.");
                    break;
                }
                wholeSpace = wholeSpace - int.Parse(input);

            }
            
            if (wholeSpace<=0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(wholeSpace)} Cubic meters more.");
            }
        }
    }
}
