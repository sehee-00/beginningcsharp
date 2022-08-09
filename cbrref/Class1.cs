using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbrref
{
    struct Vector
    {
        public int X;
        public int Y;
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(ref v1); //메서드 호출 시 ref 예약어 사용
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);
        }
        static void Change(ref Vector vt)   //메서드 측에도 해당 매개변수에 ref 예약어 사용
        {
            vt.X = 7;
            vt.Y = 14;
        }
    }
}
