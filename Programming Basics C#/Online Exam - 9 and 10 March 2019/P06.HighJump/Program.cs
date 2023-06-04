using System;

namespace P06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int purpose = int.Parse(Console.ReadLine());
            int startJump = purpose-30;
            int jumpCount = 0;
            int unsuccesCounter = 0;
            while (purpose>=startJump)
            {
                int jump = int.Parse(Console.ReadLine());
                jumpCount++;
                if (jump > startJump)
                {
                    if (startJump >= purpose)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {startJump}cm after { jumpCount} jumps.");
                        
                    }

                    startJump += 5;
                    unsuccesCounter = 0;
                }
                else
                {
                    unsuccesCounter++;
                    if (unsuccesCounter==3)
                    {
                        Console.WriteLine($"Tihomir failed at {startJump}cm after {jumpCount} jumps.");
                        break;
                    }
                }
            }
        }
    }
}
