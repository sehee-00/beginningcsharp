using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idrawingobject
{
    interface IDrawingObject
    {
        void Draw();

    }
    class Line : IDrawingObject
    {
        public void Draw() { Console.WriteLine("Line"); }
    }
    class Rectangle : IDrawingObject
    {
        public void Draw() { Console.WriteLine("Rectangle"); }
        static void Main(String[] args)
        {
            IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };

            foreach (IDrawingObject item in instances)
            {
                item.Draw();    //인터페이스를 상속받은 객체의 Draw 메서드가 호출됨
            }

            //자식 클래스로부터 암시적 형변환 가능
            IDrawingObject instance = new Line();
            instance.Draw();
        }
    }

    
    
}
