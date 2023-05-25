using System;

namespace P06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operation = char.Parse (Console.ReadLine());

           
            
            if (operation == '+'|| operation =='-'|| operation == '*')
            {
                int result;
                if (operation == '+')
                {
                    result = N1 + N2;
                }
                else if (operation== '-')
                {
                   result = N1 - N2;
                }
                else
                {
                   result = N1 * N2;
                }

                string evenOrOdd = "odd";
                if (result % 2 ==0)
                {
                    evenOrOdd = "even";
                }

                Console.WriteLine ($"{N1} {operation} {N2} = {result} - {evenOrOdd} ");


            }

            else
            {
                if (N2==0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

                else if(operation=='/')
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {(double)N1 / N2:F2}");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 % N2}");
                }
            }

        }
    }
}
