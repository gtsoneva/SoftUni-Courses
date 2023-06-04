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

            while (input != "Finish")
            {
                input = Console.ReadLine();
                int studentTicketCount = 0;
                int standardTicketCount = 0;
                int kidTicketCount = 0;
                if (input=="Finish")
                {
                    break;
                }

                int freePlaces = int.Parse(Console.ReadLine());

                for (int i = 0; i < freePlaces; i++)
                {
                  

                    string typeTicket = Console.ReadLine();

                    if (typeTicket=="student")
                    {
                        studentTicketCount++;
                    }
                    else if (typeTicket=="standard")
                    {
                        standardTicketCount++;
                    }
                    else if (typeTicket=="kid")
                    {
                        kidTicketCount++;
                    }
                    else if (typeTicket == "End")
                    {
                        break;
                    }
                    
                }
                totalStandard += standardTicketCount;
                totalStudent += studentTicketCount;
                totalKid += kidTicketCount;

                Console.WriteLine($"{input} - {((studentTicketCount+standardTicketCount+kidTicketCount)/(double)freePlaces )*100:f2}% full.");

               

            }

            Console.WriteLine($"Total tickets: {totalKid+totalStandard+totalStudent}");
            Console.WriteLine($"{((double)totalStudent/(totalStudent+totalStandard+totalKid))*100 :f2}% student tickets.");
            Console.WriteLine($"{((double)totalStandard/(totalStudent+totalStandard+totalKid))*100:f2}% standard tickets.");
            Console.WriteLine($"{((double)totalKid / (totalStudent + totalStandard + totalKid)) *100:f2}% kids tickets.");

        }
    }
}
