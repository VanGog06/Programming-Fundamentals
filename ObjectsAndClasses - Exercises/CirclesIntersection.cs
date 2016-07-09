/*
Create class Circle with properties Center and Radius. The center is a point with coordinates X and Y (make a class Point). Write a method bool Intersect(Circle c1, Circle c2) that tells whether the two given circles intersect or not. Write a program that tells if two circles intersect.
The input lines will be in format: {X} {Y} {Radius}. Print as output “Yes” or “No”.

Examples
Input	Output	
4 4 2   No
8 8 1	
	 
3 3 2   Yes
4 3 6
	 
1 1 4   Yes
4 2 5	 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    class CirclesIntersection
    {
        static void Main(string[] args)
        {
            string[] firstCircleParams = Console.ReadLine().Split();
            string[] secondCircleParams = Console.ReadLine().Split();

            int x1 = int.Parse(firstCircleParams[0]);
            int y1 = int.Parse(firstCircleParams[1]);
            int x2 = int.Parse(secondCircleParams[0]);
            int y2 = int.Parse(secondCircleParams[1]);

            double d = Math.Sqrt(Math.Pow((y2 - y1), 2) + (Math.Pow((x2 - x1), 2)));

            if (d <= int.Parse(firstCircleParams[2]) + int.Parse(secondCircleParams[2]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class Circle
    {
        public int Center { get; set; }
        public int Radius { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
