using System;
using System.Collections.Generic;
using System.Linq;
//using Xunit;

namespace CodingChallenges
{
    public class FindClosestPointsToOrigin
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return "(" + x + ", " + y + ")";
            }
        }



        class Program
        {
            static Point FindKPoint(Point[] points, int k)
            {
                //Debug.Assert(k > 0);
                //Debug.Assert(k <= points.Length);

                var ps = from p in points
                         orderby p.x * p.x + p.y * p.y ascending
                         select p;


                return (Point)(ps.Skip(k - 1).First());
            }

            //static void Main(string[] args)
            //{
            //    int noOfPoints = 1;
            //    //Point[] points = {
            //    //                 new Point(3, 3),
            //    //                 new Point(5, -1),
            //    //                 new Point(-2, 4)
            //    //             };

            //    Point[] points = {
            //                     new Point(1, 3),
            //                     new Point(-2, 2)
            //                     };


            //    for (int i = 1; i <= noOfPoints; ++i)
            //    {
            //        Console.WriteLine("#{0} -- {1} ", i, FindKPoint(points, i));
            //    }

            //    Console.ReadLine();
            //}
        }
    }
}


