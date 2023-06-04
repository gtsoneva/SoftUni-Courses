using System;

namespace P06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int countClient = int.Parse(Console.ReadLine());
            double price = 0;
            double average = 0;
          


            for (int i = 1; i <= countClient; i++)
            {
                string input = Console.ReadLine();
                int count = 0;
                double totalPrice = 0;
                while (input!="Finish")
                {

                    count++;
                    if (input=="basket")
                    {
                        price = 1.5;
                    }
                    else if(input=="wreath")
                    {
                        price = 3.80;
                    }
                    else if (input=="chocolate bunny")
                    {
                        price = 7;
                    }
                    totalPrice += price;

                   
                    input = Console.ReadLine();

                    if (input == "Finish")
                    {
                        if(count%2==0)
                        {
                            totalPrice -= totalPrice * 0.2;
                         }
                        Console.WriteLine($"You purchased {count} items for {totalPrice:f2} leva.");
                        break;
                    }
                }
                average += totalPrice;

            }

            Console.WriteLine($"Average bill per client is: {average/countClient:f2} leva.");
        }
    }
}
