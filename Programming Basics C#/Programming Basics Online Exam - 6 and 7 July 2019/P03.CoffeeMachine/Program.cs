using System;

namespace P03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCoffee = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numPotables = int.Parse(Console.ReadLine());
            double priceEspresso = 0;
            double priceCappuccino = 0;
            double priceTea = 0;
            if (typeCoffee=="Espresso")
            {
                if (sugar=="Without")
                {
                    priceEspresso = numPotables* 0.90;
                    priceEspresso = priceEspresso- priceEspresso * 0.35;

                }
                else if (sugar=="Normal")
                {
                    priceEspresso = numPotables* 1;
                }
                else
                {
                    priceEspresso = numPotables* 1.20;
                }

                if (numPotables>=5)
                {
                    priceEspresso = priceEspresso - priceEspresso * 0.25;
                }

                if (priceEspresso>15)
                {
                    priceEspresso = priceEspresso - priceEspresso * 0.20;
                }

                Console.WriteLine($"You bought {numPotables} cups of {typeCoffee} for {priceEspresso:f2} lv.");
            }
            else if (typeCoffee== "Cappuccino")
            {
                if (sugar=="Without")
                {
                    priceCappuccino = numPotables * 1;
                    priceCappuccino = priceCappuccino - priceCappuccino * 0.35;
                }
                else if (sugar=="Normal")
                {
                    priceCappuccino = numPotables * 1.20;

                }
                else
                {
                    priceCappuccino = numPotables * 1.60;
                }
                if (priceCappuccino>15)
                {
                    priceCappuccino = priceCappuccino - priceCappuccino * 0.20;
                }
                Console.WriteLine($"You bought {numPotables} cups of {typeCoffee} for {priceCappuccino:f2} lv.");
            }
            else
            {
                if (sugar== "Without")
                {
                    priceTea = numPotables * 0.50;
                    priceTea = priceTea - priceTea * 0.35;
                }
                else if (sugar=="Normal")
                {
                    priceTea = numPotables * 0.60;
                    
                }
                else
                {
                    priceTea = numPotables * 0.70;
                }
                if (priceTea>15)
                {
                    priceTea = priceTea - priceTea * 0.20;
                }
                Console.WriteLine($"You bought {numPotables} cups of {typeCoffee} for {priceTea:f2} lv.");
            }

          

               
        }
    }
}
