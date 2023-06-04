using System;

namespace P06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int maxNum = int.MinValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int num = int.Parse(input);
                if (num > maxNum)
                {
                    maxNum = num;
                }

            }
            Console.WriteLine(maxNum);

        }
    }
}
