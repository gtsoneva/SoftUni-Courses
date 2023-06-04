using System;

namespace P05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            double sumAccount = 0;
            while ((input=Console.ReadLine())!= "NoMoreMoney")
            {
                double depositAmount = double.Parse(input);

                if (depositAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {depositAmount:f2}");
                sumAccount += depositAmount;
            }
            Console.WriteLine($"Total: {sumAccount:f2}");
        }
    }
}
