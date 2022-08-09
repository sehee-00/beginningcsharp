using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tostring
{
    class Point
    {
        int x, y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X : " + x + ", Y : " + y;
        }

        static void Main(String[] args)
        {
            Point pt = new Point(5, 10);
            Console.WriteLine(pt.ToString());
        }
    }
}
