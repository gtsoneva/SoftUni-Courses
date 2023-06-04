using System;

namespace P01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chineseYuan =double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            commission = commission * 0.01;

            double priceBitcoin = bitcoin * 1168;
            double priceChineiseYuan = (chineseYuan * 0.15 * 1.76);
            double price = (priceBitcoin + priceChineiseYuan) / 1.95;
            double commissionPrice = price*commission;
            double totalPrice = price - commissionPrice;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
