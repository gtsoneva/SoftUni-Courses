using System;

namespace P03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            bool isPrime;
            while (input != "stop")
            {
               int currentNum = int.Parse(input);

                isPrime = true;

                if (currentNum<0)
                {
                    Console.WriteLine("Number is negative.");

                }
                else
                {
                    for (int i =2 ; i < currentNum; i++)
                    {
                        if(currentNum%i==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime==true)
                {
                    if (currentNum > 0)
                    {
                        sumPrime += currentNum;
                    }
                }
                else 
                {
                    sumNonPrime += currentNum;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.Write($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
