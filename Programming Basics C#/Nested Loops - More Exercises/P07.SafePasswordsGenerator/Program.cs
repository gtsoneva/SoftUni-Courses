using System;

namespace P07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int maxPass = int.Parse(Console.ReadLine());
            int count = 0;
            bool flag = false;


            for (int i = 35; i <=55; i++)
    
            {
                for (int k = 64; k <= 96 ; k++)      
                {
                    for (int j = 1; j <=a; j++)
                    {
                        for (int l = 1; l <=b; l++)
                        {
                            char one = ((char)i);
                            char two = ((char)k);
                           

                            Console.Write($"{one}{two}{j}{l}{two}{one}|");
                            count += 1;
                            i++;
                            k++;
                            if (count>= maxPass)
                            {
                                flag = true;
                               
                                break;
                            }
                           
                            if (j==a && l==b)
                            {
                                flag = true;
                                break;
                            }
                           
                            
                            if (i>55)
                            {
                                i = 35;
                            }
                            if (k>96)
                            {
                                k = 64;
                            }
                           
                        }
                        if (flag)
                        {
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }

                }
                if (flag)
                {
                    break;
                }
            }
           

        }
    }
}
