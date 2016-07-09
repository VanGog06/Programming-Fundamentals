/*
Write a program to read n points and find the closest two of them.

Input
The input holds the number of points n and n lines, each holding a point {X and Y coordinate}.

Output
•	The output holds the shortest distance and the closest two points.
•	If several pairs of points are equally close, print the first of them (from top to bottom). 

Examples
Input	            Output	            Comments
4                   1.414               The closest two points are {3, 4} and {2, 5} at distance 1.4142135623731 ≈ 1.414.
3 4                 (3, 4)
6 8                 (2, 5)
2 5
-1 3	
	 	
3                   0.000               Two of the points have the same coordinates {6, 18}, so the 
12 -30              (6, 18)             distance between them is 0.
6 18                (6, 18)
6 18	

3                   1.414               The pairs of points {{1, 1}, {2, 2}} and {{2,2}, {3,3}} stay at the same distance,
1 1                 (1, 1)              but the first pair is {{1, 1}, {2, 2}}. The distance between them 
2 2                 (2, 2)              is 1.4142135623731 ≈ 1.414.
3 3		 	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int numberOfPoint = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < numberOfPoint; i++)
            {
                int[] pointParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Point p = new Point() { X = pointParameters[0], Y = pointParameters[1] };

                points.Add(p);
            }

            double currentDistance = 0.0;
            double minDistance = double.MaxValue;
            Point p1 = new Point();
            Point p2 = new Point();

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    currentDistance = points[i].calculateDistance(points[j]);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        p1 = points[i];
                        p2 = points[j];
                    }
                }
            }

            Console.WriteLine("{0:F3}", minDistance);
            Console.WriteLine("({0}, {1})", p1.X, p1.Y);
            Console.WriteLine("({0}, {1})", p2.X, p2.Y);
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double calculateDistance(Point p)
        {
            return Math.Sqrt(Math.Pow((this.X - p.X), 2) + Math.Pow((this.Y - p.Y), 2));
        }
    }
}
