using System;

namespace P03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            int countC = 0;
            int countO = 0;
            int countN = 0;
            string word = string.Empty;
            string secretWord = string.Empty;
            

            while (symbol!= "End")
            {
                char letter = char.Parse(symbol);
                if (letter>='a' && letter<= 'z' || letter>='A' && letter <= 'Z')
                {
                    if (symbol == "c" && countC == 0)
                    {
                        countC++;

                    }
                    else if (symbol == "o" && countO == 0)
                    {
                        countO++;
                    }
                    else if (symbol == "n" && countN == 0)
                    {
                        countN++;
                    }
                    else
                    {
                        word += letter;
                    }
                    if (countC + countO + countN ==3)
                    {
                        secretWord += word;
                        secretWord += ' ';
                        word = string.Empty;
                        countO = 0;
                        countC = 0;
                        countN = 0;
                        
                    }
                }

                symbol = Console.ReadLine();
            }
           
            
                Console.WriteLine(secretWord);
              
            
              
        }
    }
}
