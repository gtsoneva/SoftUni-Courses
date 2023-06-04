using System;

namespace P06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            int count = 0;
            double bestSum = 0;
            string bestFilm = string.Empty;

            while (nameFilm !="STOP")
            {
                int sum = 0;
                count++;
                
                if (count==7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }

                for (int i = 0; i < nameFilm.Length; i++)
                {
                    if (nameFilm[i] >='A'  && nameFilm[i] <= 'Z')
                    {
                        sum += nameFilm[i] - nameFilm.Length;
                    }
                    else if ( nameFilm[i] >='a' && nameFilm[i]<='z')
                    {
                        sum += nameFilm[i] - 2 * nameFilm.Length;
                    }
                    else
                    {
                        sum += nameFilm[i];
                    }
                }
                if (sum>bestSum)
                {
                    bestSum = sum;
                    bestFilm = nameFilm;
                }
                nameFilm = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {bestFilm} with {bestSum} ASCII sum.");
        }
    }
}
