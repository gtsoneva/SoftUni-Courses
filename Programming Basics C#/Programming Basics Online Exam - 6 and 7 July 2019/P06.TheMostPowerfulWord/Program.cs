using System;

namespace P06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int bestScore = 0;
            int currentScore = 0;
            string mostPowerfulWord = "";
           

            while (word != "End of words")
            {
                for (int i = 0; i < word.Length; i++)
                {
                    currentScore += word[i];
                }
                if (word[0] == 'a' || word[0] == 'A' || word[0] == 'e' || word[0] == 'E' || word[0] == 'i' || word[0] == 'I' || word[0] == 'o' || word[0] == 'O' || word[0] == 'u'
                    || word[0] == 'U' || word[0] == 'y' || word[0] == 'Y')
                {
                    currentScore *= word.Length;
                }
                else
                {
                    currentScore = currentScore / word.Length;
                }
                if (currentScore > bestScore)
                {

                    mostPowerfulWord = word;
                    bestScore = currentScore;

                }
                currentScore = 0;
                word = Console.ReadLine();
                if (word == "End of words")
                {
                    Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {bestScore}");
                    break;
                }
            }
        }
    }
}
