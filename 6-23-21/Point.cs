using System;
using System.Collections.Generic;
using System.Text;

namespace _6_23_21
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double CalculateDistance()
        {
            return Math.Sqrt((X * X) + (Y * Y));
        }
        public (double xMid, double yMid) CalculateMidpoint(int input1, int input2)
        {
            //make sure to keep each method single function

            double xMidpoint = (X + input1) / 2;

            double yMidpoint = (Y + input2) / 2;

            return (xMidpoint, yMidpoint);
        }
    }
}
