using System;

namespace P08.OnTimeForTtheExam
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Четем от козолата 
                //час на изпита 
                //минути на изпита
                //час на пристигане
                //минути на пристигане
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            //2.Преобразуваме часовете и минутите в минути

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            //3.Намираме разликата между минутите на изпита и минутите на пристигане

            int difference = examMin - arrivalMin;

            //4.В зависимост от разликата намираме дали е закъснял.подранил или навреме

            // •“Late”, ако студентът пристига по-късно от часа на изпита.  // difference <0
            // => ако е закъснял повече или точно час 
        

            if (difference<0)
            {
                Console.WriteLine("Late");

                //=> е закъснял по малко от час 
                if (difference>-60)
                {
                    Console.WriteLine($"{Math.Abs (difference)} minutes after the start");
                }
                else
                {
                   Console.WriteLine($"{Math.Abs(difference/60)} {Math.Abs(difference%60):D2} hours after the start");
                }
            }

            //“On time”, // difference >=0 && difference <=30
              //=> до 30 минути по-рано от изпита

            else if (difference >= 0 && difference <= 30)

            {
                Console.WriteLine("On time");
                //=> дошъл до 30 мин преди изпита

              
                if (difference>0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                  
            }

           
            else
            {
                Console.WriteLine("Early");

                // => подранил повече или точно час
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else // => подранил с по малко от час
                {

                    Console.WriteLine($"{difference / 60}:{difference % 60:D2} hours before the start");

                }
            }

        }
    }
}
