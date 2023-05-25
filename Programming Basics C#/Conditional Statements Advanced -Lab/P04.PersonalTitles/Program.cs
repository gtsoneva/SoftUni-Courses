using System;

namespace P04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if(gender== "m")
            {
                if (age>=16)
                {
                    Console.WriteLine("Mr.");
                }
                else if (age<16)
                {
                    Console.WriteLine("Master");
                }
            }
               if (gender=="f")
            {
                if (age>=16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (age<16)
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
