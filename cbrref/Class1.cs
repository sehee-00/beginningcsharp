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
    class Point
    {
        public int X;
        public int Y;
    }
    class Class1
    {
        static void Main(string[] args)
        {
            /*Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(ref v1); //메서드 호출 시 ref 예약어 사용
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);

            Point pt1 = new Point();
            pt1.X = 5;
            pt1.Y = 10;

            ChangeP(ref pt1);    //메서드 호출 : ref 예약어 사용
            Console.WriteLine("pt1: x = " + pt1.X + ", Y = " + pt1.Y);*/

            Point pt2 = null;

            Change1(pt2); //메서드 호출 : 얕은 복사
           // Console.WriteLine("pt2: X = " + pt2.X + ", Y = " + pt2.Y); // 널포인트익셉션

            Change2(ref pt2); //메서드 호출 : ref 사용
            Console.WriteLine("pt2: X = " + pt2.X + ", Y = " + pt2.Y);


            int value1 = 5;
            int value2 = 10;

            Swapvalue(ref value1, ref value2);

            Console.WriteLine("value1 == " + value1 + ", value2 == " + value2);


        }
        private static void Swapvalue(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static void Change(ref Vector vt)   //메서드 측에도 해당 매개변수에 ref 예약어 사용
        {
            vt.X = 7;
            vt.Y = 14;
        }

        static void ChangeP(ref Point pt)   //첫 번째 매개변수에 ref 예약어 사용
        {
            pt.X = 7;
            pt.Y = 14;
        }

        private static void Change1(Point pt)   //얕은 복사
        {
            pt = new Point();
            pt.X = 6;
            pt.Y = 12;
        }

        private static void Change2(ref Point pt)   //ref를 이용한 참조에 의한 호출
        {
            pt = new Point();
            pt.X = 7;
            pt.Y = 14;
        }
    }
}
