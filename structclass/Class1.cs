using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structclass
{
    struct Vector
    {
        public int x;
        public int y;
    }
    class Point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(String[] args)
        {
            Vector v1;
            v1.x = 5;
            v1.y = 10;

            Vector v2 = v1;
            v2.x = 7;
            v2.y = 14;

            Console.WriteLine("v1 : X = " + v1.x + ", Y = " + v1.y);
            Console.WriteLine("v2 : X = " + v2.x + ", Y = " + v2.y);

            Change(v1);
            Console.WriteLine("change(v1) : X = " + v1.x + ", Y = " + v1.y);
            Console.WriteLine("----------------------------------");

            Point pt1 = new Point();
            pt1.x = 5;
            pt1.y = 10;

            Point pt2 = pt1;
            pt2.x = 7;
            pt2.y = 14;

            Console.WriteLine("pt1 : X = " + pt1.x + ", Y = " + pt1.y);
            Console.WriteLine("pt2 : X = " + pt2.x + ", Y = " + pt2.y);

            ChangeP(pt1);
            Console.WriteLine("change(pt1) : X = " + pt1.x + ", Y = " + pt1.y);

        }
        private static void Change(Vector vt)
        {
            vt.x = 7;
            vt.y = 14;
        }
        private static void ChangeP(Point pt)
        {
            pt.x = 7;
            pt.y = 14;
        }
    }
}
