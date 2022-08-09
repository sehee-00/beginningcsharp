using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5._1._5
{
    struct Vector
    {
        public int X;
        public int Y;
        public Vector(int x, int y) //매개변수를 가진 생성자 정의
        {
            this.X = x;
            this.Y = y; 
        }
        public override string ToString()   //System.Object의 ToString을 재정의
        {
            return "X: " + X + ", Y: " + Y;
        }
    }
    class Program
    { 
        static void Main(String[] args)
        {
            Vector v1 = new Vector();   //new를 사용해 인스턴스 생성 가능
            Vector v2;                  //new가 없어도 인스턴스 생성 가능

            Vector v3 = new Vector(5, 10);  //명시적으로 생성자 지정 가능

            Console.WriteLine(v3);
        }
    }

}
