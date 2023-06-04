using System;

namespace P01.OldBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int counter = 0;
            
            string input = Console.ReadLine();

            while (input != "No More Books")
            {
                if (input == favoriteBook)
                {
                    break;
                }
                counter++;

                input = Console.ReadLine();
            }
            if (input == favoriteBook)
             {
                Console.WriteLine($"You checked {counter} books and found it.");
            }

            else
            { 
                Console.WriteLine($"The book you search is not here!");

                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
