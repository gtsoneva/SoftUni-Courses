using System;

namespace P07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 Четем от конзолата 
            // 1.	x – височината на къщата – реално число в интервала [2...100]
            double heightOfHouse= double.Parse(Console.ReadLine());

            //2– дължината на страничната стена – реално число в интервала[2...100]

            double lengthOfSideWall =double.Parse(Console.ReadLine());

            // 3.	h – височината на триъгълната стена на прокрива – реално число в интервала [2...100]

            double heightOfTriangularWallOfEaves = double.Parse(Console.ReadLine());


            double sideWall = heightOfHouse * lengthOfSideWall;
            double window = 1.5 * 1.5;
            double twoSide = 2 * sideWall - 2 * window;
            double backWall = heightOfHouse * heightOfHouse;
            double entrance = 1.2 * 2;
            double totalFrontAndRear = 2 * backWall - entrance;
            double totalAreaWall = twoSide + totalFrontAndRear;
            double greenPaint = totalAreaWall / 3.4;


            double twoRectanglesRoof = 2 * (heightOfHouse * lengthOfSideWall);
            double twotriangles = 2 * (heightOfHouse * heightOfTriangularWallOfEaves / 2);
                double totalAreaRoof = twoRectanglesRoof + twotriangles;
            double redPaint = totalAreaRoof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");


        } 
        

    }
}
