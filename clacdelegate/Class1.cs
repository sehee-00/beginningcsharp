using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clacdelegate
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        static void Main(String[] args)
        {
            CalcDelegate calc = Add;
            calc += Subtract;//아래 두 식과 동일한 내용
            /*CalcDelegate subtractCalc = new CalcDelegate(Subtract);
            calc = CalcDelegate.Combine(calc, subtractCalc) as CalcDelegate;*/
            calc += Multiply;
            calc += Divide;

            calc -= Multiply;   //*연산 제외하고 출력

            calc(10, 5);
        }

    }
}
