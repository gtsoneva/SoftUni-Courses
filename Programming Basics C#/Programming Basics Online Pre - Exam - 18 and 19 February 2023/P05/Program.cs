using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            int purposeForDay = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
           
            double totalSumPerDay = 0;
            

            while (input != "closed")
            {
                
                   
                if (input == "haircut")
                {
                    string command = Console.ReadLine();
                    if (command=="mens")
                    {
                        totalSumPerDay += 15;
                    }
                    else if (command=="ladies")
                            {
                        totalSumPerDay+= 20;
                    }
                    else if (command=="kids")
                    {
                        totalSumPerDay+= 10;
                    }

                }
                else if (input=="color")
                {
                    string command = Console.ReadLine();

                    if (command=="touch up")
                    {
                        totalSumPerDay+= 20;
                    }
                    else if (command=="full color")
                    {
                        totalSumPerDay += 30;
                    }
                }
                
                
                if (totalSumPerDay>=purposeForDay)
                {
                    break;
                }
                
                input = Console.ReadLine();
                if (input == "closed")
                {
                    break;
                }
            }
            
            if (totalSumPerDay>=purposeForDay)
            {
                Console.WriteLine($"You have reached your target for the day!");
                Console.WriteLine($"Earned money: {totalSumPerDay}lv.");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {Math.Abs(purposeForDay-totalSumPerDay)}lv. more.");
                Console.WriteLine($"Earned money: {totalSumPerDay}lv.");
            }
        }
    }
}
