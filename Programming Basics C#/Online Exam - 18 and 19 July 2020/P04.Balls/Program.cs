using System;

namespace P04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int other = 0;
            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    red++;
                    totalPoints += 5;
                }
                else if (color == "orange")
                {
                    orange++;
                    totalPoints += 10;
                }
                else if (color == "yellow")
                {
                    yellow++;
                    totalPoints += 15;
                }
                else if (color=="white")
                {
                    white++;
                    totalPoints += 20;
                }
                else if (color=="black")
                {
                    black++;
                    totalPoints = (Math.Floor(totalPoints / 2));
                }
                else
                {
                    other++;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");


        }
    }
}
