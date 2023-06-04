using System;

namespace P01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNum; i+=2)
            {
                for (int k = 2; k <= secondNum; k++)
                {
                    for (int j = 2; j <=thirdNum; j+=2)
                    {
                        if (k == 2 || k == 3 || k == 5 || k == 7)
                        {
                            Console.WriteLine(i + " " + k + " " + j);
                        }
                    }
                }
            }
        }
    }
}
