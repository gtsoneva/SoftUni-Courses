using System;

namespace P07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupNum = double.Parse(Console.ReadLine());


            int climbersMusala = 0;
            int climbersMonblan = 0;
            int climbersKilimandjaro = 0;
            int climbersK2 = 0;
            int climbersEverest = 0;



            for (int i=1; i<= groupNum; i++ )
            {
                int numClimbers = int.Parse(Console.ReadLine());

                if (numClimbers <= 5)
                {
                    climbersMusala= climbersMusala+ numClimbers;
                }
                else if (numClimbers >= 6 && numClimbers <= 12)
                {
                    climbersMonblan= climbersMonblan+ numClimbers;
                }
                else if (numClimbers >= 13 && numClimbers <= 25)
                {
                    climbersKilimandjaro=climbersKilimandjaro+numClimbers;
                }
                else if (numClimbers >= 26 && numClimbers <= 40)
                {
                    climbersK2=climbersK2+numClimbers;
                }
                else
                {
                    climbersEverest=climbersEverest+numClimbers;
                }

            }

            int totalClimbers = climbersMusala + climbersMonblan + climbersKilimandjaro + climbersK2 + climbersEverest;

            Console.WriteLine($"{(double)climbersMusala / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)climbersMonblan / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)climbersKilimandjaro / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)climbersK2 / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)climbersEverest / totalClimbers * 100:F2}%");
        }
    }
}
