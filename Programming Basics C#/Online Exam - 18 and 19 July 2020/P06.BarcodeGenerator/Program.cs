using System;

namespace P06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            string secondNumber = Console.ReadLine();

            int number1 = int.Parse(firstNumber);

            int number2 = int.Parse(secondNumber);

            char firstNumber1 = firstNumber[0];

            char secondNumber1 = firstNumber[1];

            char treeNumber1 = firstNumber[2];

            char fourNumber1 = firstNumber[3];


            char firstNumber2 = secondNumber[0];

            char secondNumber2 = secondNumber[1];

            char treeNumber2 = secondNumber[2];

            char fourNumber2 = secondNumber[3];

            int sum;

            for (int i = firstNumber1 - 48; i <= firstNumber2 - 48; i++)
            {
                for (int j = secondNumber1 - 48; j <= secondNumber2 - 48; j++)
                {
                    for (int k = treeNumber1 - 48; k <= treeNumber2 - 48; k++)
                    {
                        for (int f = fourNumber1 - 48; f <= fourNumber2 - 48; f++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && f % 2 != 0)
                            {

                                int i1 = i;

                                int j2 = j;

                                int k2 = k;

                                int f2 = f;

                                sum = i1 * 1000 + j2 * 100 + k2 * 10 + f2 * 1;

                                if (sum >= number1 && sum <= number2)
                                {
                                    Console.Write("{0} ", sum);
                                }

                            }


                        }
                    }
                }
            }

            Console.WriteLine();

        }
    }
}