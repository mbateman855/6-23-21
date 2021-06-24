using System;

namespace _6_23_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise55();
        }
       
        static void Exercise42()
        {
            // put a do while
            Console.WriteLine("Please enter two coordinates:");

            Console.Write("Coordinate 1: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Coordinate 2: ");
            int input2 = int.Parse(Console.ReadLine());

            Point point = new Point(input1, input2);

            Console.WriteLine($"You've created a point object ({point.X}, {point.Y})");

            //Console.WriteLine("Would you like to continue? (y/n)");
            //string cont = Console.ReadLine();

            Console.WriteLine("Distance between the two points is " + point.CalculateDistance());

            Console.WriteLine("Please enter a point to compare: ");

            Console.Write("X coordinate: ");
            int xInput = int.Parse(Console.ReadLine());

            Console.Write("Y coordinate: ");
            int yInput = int.Parse(Console.ReadLine());

            var (xMid, yMid) = point.CalculateMidpoint(xInput, yInput);

            Console.WriteLine($"The midpoint between ({point.X}, {point.Y}) and ({xInput}, {yInput}) is ({xMid},{yMid})");
        }
        static void Exercise55()
        {
            var cat = new Cat();
            cat.Eat();

            
        }
    }
}
