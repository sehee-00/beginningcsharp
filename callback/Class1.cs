using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callback
{
    //델리게이트는 여러 개의 메서드를 담을 수 있어서 한 번의 호출을 통해 다중으로 등록된 콜백 메서드를 호출할 수 있다. 
    delegate int GetResultDelegate();

    class Target
    {
        public void Do(GetResultDelegate getResult)
        {
            Console.WriteLine(getResult()); //콜백 메서드 호출
        }
        static void Main(String[] args)
        {
            Source s = new Source();
            s.Test();
        }
    }
    class Source { 
        public int GetResult()
        {
            return 10;
        }
        public void Test()
        {
            Target target = new Target();
            target.Do(new GetResultDelegate(this.GetResult));
        }
        
    }
}
