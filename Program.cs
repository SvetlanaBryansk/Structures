using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 5);

            Console.WriteLine(a.GetDistance(b));
        }

        private static double GetDistance(Point a, Point b)
        {
            int x = a.X -b.X;
            int y = a.Y -b.Y;

            return Math.Sqrt(x * x + y * y);
        }
    }
}
