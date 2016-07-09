/*
Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. Write a program to read 
two points (given as two integers) and print the Euclidean distance between them.

Examples
Input	        Output
3 4             5.000
6 8	

3 4             2.000
5 4	

8 -2            11.402
-1 5	
*/

using System;

namespace _04.DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();

            int x1 = int.Parse(firstLine[0]);
            int y1 = int.Parse(firstLine[1]);

            firstLine = Console.ReadLine().Split();

            int x2 = int.Parse(firstLine[0]);
            int y2 = int.Parse(firstLine[1]);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            Console.WriteLine(CalculateDistance(p1, p2));
        }

        public static double CalculateDistance (Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
