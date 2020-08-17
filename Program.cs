using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What monument would you like to work with? ");
            string s = Console.ReadLine();
            CalculateTotalCost(s);
        }


        public static void CalculateTotalCost(string input)
        {
            double totalCost;

            if (input == "Teotihuacan")
            {
                double rectanglePart = rectangleArea(2500, 1500);
                double halfCirclePart = circleArea(375) / 2;
                double trianglePart = triangleArea(750, 500);
                double totalArea = rectanglePart + halfCirclePart + trianglePart;
                totalCost = Math.Round(totalArea * 180, 2);
                
            }
            else if(input == "Taj Mahal")
            {
                double wholeSquareArea = 90.5 * 90.5;
                totalCost = Math.Round(wholeSquareArea - 4 * triangleArea(24, 24),2);
                
            }

            else if(input == "Great Mosque of Mecca")
            {
                double wholeRectangleArea = rectangleArea(264, 180);
                totalCost = Math.Round(wholeRectangleArea - 2 * rectangleArea(106, ((264 - 180) / 2)) - triangleArea(84,264),2);
            }
            else
            {
                totalCost = 0.00; //handle the invalid input
            }

            Console.WriteLine("The plan for that monument costs " + totalCost+ " pesos!");


        }
        public static double rectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double circleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double triangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
