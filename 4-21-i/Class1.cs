using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_21_i
{
    //인터페이스는 하나의 타입에서 여러 개의 메서드 계약을 담을 수 있다. 
    interface ISource
    {
        int GetResult();    //콜백용으로 사용될 메서드를 인터페이스로 분리한다.
    }
    class Source : ISource
    {
        public int GetResult() { return 10; }

        public void Test()
        {
            Target target = new Target();
            target.Do(this);
        }
    }
    class Target
    {
        public void Do(ISource obj) //Source 타입이 아닌 ISource 인터페이스를 받는다. 
        {   
            Console.WriteLine(obj.GetResult()); //콜백 메서드 호출
        }
        static void Main(String[] args)
        {
            Source s = new Source();
            s.Test();
        }
    }
}
