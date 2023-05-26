using System;

namespace P06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int expensesMonths = int.Parse(Console.ReadLine());

            
            double othersBills = 0;
            double others = 0;
            int water = 20;
            double waterBills = 0;
            int internet = 15;
            double internetBills = 0;
            double elecricityBills = 0;


            for (int i = 1; i <= expensesMonths; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                elecricityBills += electricity;

                others = (electricity + water + internet) + (electricity + water + internet) * 0.2;
                othersBills += others;
                waterBills += water;
                internetBills += internet;


            }
            double average = (elecricityBills + othersBills + waterBills + internetBills )/ expensesMonths;
            Console.WriteLine($"Electricity: {elecricityBills:f2} lv");
            Console.WriteLine($"Water: {waterBills:f2} lv");
            Console.WriteLine($"Internet: {internetBills:f2} lv");
            Console.WriteLine($"Other: {othersBills:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
