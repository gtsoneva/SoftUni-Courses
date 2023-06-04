using System;

namespace P14.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());


            for (int i = 1 ; i <=n; i++)
            {
                for (int k = 1; k <=n; k++)
                {
                    for (char m ='a';  m < 'a' + l;  m++)
                    {
                        for (char x = 'a'; x <'a'+ l; x++)
                        {
                            for (int y = 1; y <= n; y++)
                            {
                                if (y > i && y > k)
                                {
                                    Console.Write($"{i}{k}{(char)m}{(char)x}{y} ");
                                  
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
