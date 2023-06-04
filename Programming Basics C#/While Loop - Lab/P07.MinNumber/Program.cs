using System;

namespace P07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int minNum = int.MaxValue;

            while ((input=Console.ReadLine())!="Stop")
            {
                int num = int.Parse(input);
                
                if (num<minNum)
                {
                    minNum = num;

                }

            }
            Console.WriteLine(minNum);
        }
    }
}
