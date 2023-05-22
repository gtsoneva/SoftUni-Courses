    using System;

    namespace P07._ProjectsCreation
    {
        class Program
        {
            static void Main(string[] args)
            {
           
                string name = Console.ReadLine();
                int projectTime = int.Parse(Console.ReadLine());
                int project= projectTime * 3;
                Console.Write ($"The architect {name} will need {project} hours to complete {projectTime} project/s.");

            }
        }
    }
