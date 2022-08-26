using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumE
{
    public delegate void MoveHandler(int a, int b, A a1, B b1);
    
    public class Class2
    {
        public event MoveHandler Move;

        public void MouseMove()
        {
            if (Move != null)
            {
                Move(1, 1, new A(), new B());
            }
        }

    }

    public class ClassExe
    {
        Class2 c2;
        public void Test()
        {
            c2 = new Class2();
            c2.Move += C2_Move;
        }

        private void C2_Move(int a, int b, A a1, B b1)
        {
            
        }
    }

    class A { }
    class B { }
}
