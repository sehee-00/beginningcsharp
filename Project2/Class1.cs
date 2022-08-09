using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }
        static void Main(String[] args)
        {
            /*Mammal one = new Mammal();
            one.Move();

            Lion lion = new Lion();
            lion.Move();

            Whale whale = new Whale();
            whale.Move();

            Human human = new Human();
            human.Move();*/

            Lion lion = new Lion();
            Mammal one = lion;//부모 타입으로 형변환

            one.Move();

            Human human = new Human();
            Mammal two = human;
            two.Move();
        }
    }
    class Lion : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("네 발로 이동한다.");
        }
    }
    class Whale : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("헤엄친다.");
        }
    }
    class Human : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("두 발로 걷는다.");
        }
    }
}
