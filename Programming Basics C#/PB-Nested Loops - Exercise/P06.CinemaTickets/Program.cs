using System;

namespace P06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
           
        
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;


            while (input!= "Finish")
            {
                input = Console.ReadLine();
                int standardTicketCount = 0;
                int kidTicketCount = 0;
                int studentTicketCount = 0;
                if (input=="Finish")
                {
                    break;
                }
                int freeSeats = int.Parse(Console.ReadLine());
                
                for (int i = 0; i <freeSeats; i++)
                {
                    string ticket = Console.ReadLine();
                    if (ticket=="standard")
                    {
                        standardTicketCount++;
                    }
                    else if (ticket=="kid")
                    {
                        kidTicketCount++;
                    }
                    else if (ticket== "student")
                    {
                        studentTicketCount++;
                    }
                    else if (ticket=="End")
                    {
                        break;
                    }
           
                }
               
                totalStandard += standardTicketCount;
                totalStudent += studentTicketCount;
                totalKid += kidTicketCount;
              

                Console.WriteLine($"{input} - { ((studentTicketCount+standardTicketCount+ kidTicketCount) /(double)freeSeats) * 100:f2}% full.");


            }
            
            Console.WriteLine($"Total tickets: {totalStudent + totalStandard + totalKid}");
            Console.WriteLine($"{((double)totalStudent / (totalStudent + totalStandard + totalKid)) *100:f2}% student tickets.");
            Console.WriteLine($"{((double)totalStandard / (totalStudent + totalStandard + totalKid)) *100:f2}% standard tickets.");
            Console.WriteLine($"{((double)totalKid / (totalStudent + totalStandard + totalKid)) *100:f2}% kids tickets.");




        }
    }
}
