using System;

namespace P06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
           
            int wholeCake = width * length;

            

            while (wholeCake>=0)
            {
               string input = Console.ReadLine();
           
                if (input == "STOP")
                {
                    Console.WriteLine($"{wholeCake} pieces are left.");
                    break;
                }

                wholeCake = wholeCake - int.Parse(input);

            }
            if (wholeCake < 0)
            { 
                Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
            }    
        }
    }
}
