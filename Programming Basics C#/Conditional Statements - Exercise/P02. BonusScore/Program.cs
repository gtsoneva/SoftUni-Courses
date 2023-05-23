using System;

namespace P02._BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Четем от конзолата цяло число
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.00;

            //2. Пресмятаме бонус точките 
            //	Ако числото е до 100 включително, бонус точките са 5.
            if (num <= 100)
            {
                bonus = 5;
            }

            //Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            else if (num > 1000)
            {
                bonus = num * 0.1;
            }
            //Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
            else
            {
                bonus = num * 0.2;
            }

                //3  Пресмятаме допълнителни бонус точки
                //	За четно число  + 1 т.

                //За число, което завършва на 5  +2 т.


                if (num % 2 == 0)
                {
                    bonus = bonus + 1;
                }
                else if (num % 10 ==5)
                {
                    bonus = bonus + 2;

                }
                Console.WriteLine(bonus);
                Console.WriteLine( bonus + num);



            
        }
    }
}
