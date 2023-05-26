using System;

namespace P02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int yesPatient = 0;
            int noPatient = 0;

            for (int i =1;i<=period;i++)
            {
                if (i % 3 == 0)
                {
                    if (noPatient > yesPatient)
                    {
                        doctors++;
                    }
                }

                int currentPatients = int.Parse(Console.ReadLine());

                if (doctors < currentPatients)
                {
                    yesPatient += doctors;
                    noPatient += currentPatients - doctors;
                }
                else
                {
                    yesPatient += currentPatients;
                }
            }
            Console.WriteLine($"Treated patients: {yesPatient}.");
            Console.WriteLine($"Untreated patients: {noPatient}.");
        }
    }
}
            