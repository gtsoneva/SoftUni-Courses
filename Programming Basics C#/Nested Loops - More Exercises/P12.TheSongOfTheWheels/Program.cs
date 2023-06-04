using System;

namespace P12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());
            int magicNumber = 0;
            int counter = 0;
            int passwordFirstNumber = 0;
            int passwordSecondNumber = 0;
            int passwordThirdNumber = 0;
            int passwordFourthNumber = 0;
            bool flag = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            magicNumber = a * b + c * d;
                            if (a < b && c > d && magicNumber==controlNum)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    passwordFirstNumber = a;
                                    passwordSecondNumber = b;
                                    passwordThirdNumber = c;
                                    passwordFourthNumber = d;

                                    flag = true;
                                }
                                else if (counter == 0)
                                {
                                    Console.WriteLine($"No!");
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine($"No!");
                
            }
            if (flag)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {passwordFirstNumber}{passwordSecondNumber}{passwordThirdNumber}{passwordFourthNumber}");
            }
        }
    }
}

