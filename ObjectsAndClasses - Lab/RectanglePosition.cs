/*
Write a program to read two rectangles {left, top, width, height} and print whether the first is inside the second.
The input is given as two lines, each holding a rectangle, described by 4 integers: left, top, width and height.

Examples
Input	        Output	        Comments
4 -3 6 4        Inside          The first rectangle stays inside the second.
2 -3 10 6	
	 	
2 -3 10 6       Not inside      The rectangles intersect, no the first is not inside the second.
4 -5 6 10		 	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            int[] firstRect = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondRect = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle r1 = new Rectangle() { Left = firstRect[0], Top = firstRect[1], Width = firstRect[2], Heigh = firstRect[3] };
            Rectangle r2 = new Rectangle() { Left = secondRect[0], Top = secondRect[1], Width = secondRect[2], Heigh = secondRect[3] };

            if (r1.isInside(r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Heigh { get; set; }

        public int Right {
            get
            {
                return Left + Width;
            }
        }

        public int Bottom
        {
            get
            {
                return Top + Heigh;
            }
        }

        public bool isInside(Rectangle r)
        {
            bool isLeftInside = this.Left >= r.Left;
            bool isRightInside = this.Right <= r.Right;
            bool isTopInside = this.Top <= r.Top;
            bool isBottomInside = this.Bottom <= r.Bottom;

            return isLeftInside && isRightInside && isTopInside && isBottomInside;
        }
    }
}
