using System;

namespace P03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string pacet= Console.ReadLine();
            string vipYesOrNo = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
         
            double price = 0;

            if (days<1)
            {
                Console.WriteLine("Days must be positive number!");
            }
        if (days>7)
            {
                days = days - 1;
            }
            if (town== "Bansko" || town== "Borovets")
            {

                if (pacet== "withEquipment" && days>=1)
                {
                    price = 100;
                    if (vipYesOrNo=="no")
                    {
                        price = price * days;
                        
                    }
                    else
                    {
                        price = (price - price * 0.10) * days;
                    }
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
               else if (pacet== "noEquipment" && days>=1)
                {
                    price = 80;
                    if (vipYesOrNo == "no")
                    {
                        price = price * days;

                    }
                    else
                    {
                        price = (price - price * 0.05) * days;
                    }
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else if (pacet!= "withEquipment" || pacet != "noEquipment" && days >=1)
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }

            else if (town=="Varna" || town=="Burgas")
            {
                if (pacet == "withBreakfast" && days>1)
                {
                    price = 130;
                    if (vipYesOrNo == "no")
                    {
                        price = price * days;

                    }
                    else
                    {
                        price = (price - price * 0.12) * days;
                    }
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else if (pacet == "noBreakfast" && days>=1)
                {
                    price = 100;
                    if (vipYesOrNo == "no")
                    {
                        price = price * days;

                    }
                    else
                    {
                        price = (price - price * 0.07) * days;
                    }
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else if (pacet!= "withBreakfast" || pacet != "noBreakfast" && days >=1)
                {
                    Console.WriteLine("Invalid input!");
                    
                }
                
            }
            else if (town != "Bansko" && town != "Borovets" && town!= "Varna" && town != "Burgas")
            {
                Console.WriteLine("Invalid input!");
                
            }
            
        }

    
    }
}
