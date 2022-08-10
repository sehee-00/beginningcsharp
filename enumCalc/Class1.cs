using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumCalc
{
    public class Program
    {
        enum CalcType { Add, Minus, Multiply, Divide }


        int Calc(CalcType onType, int operand1, int operand2)
        {
            switch (onType)
            {
                case CalcType.Add: return operand1 + operand2;
                case CalcType.Minus: return operand1 - operand2;
                case CalcType.Multiply: return operand1 * operand2;
                case CalcType.Divide: return operand1 / operand2;
            }
            return 0;
        }
        public static void Main(String[] args)
        {
            var calc = new Program();
            Console.WriteLine(calc.Calc(CalcType.Add, 5, 6));
        }
    }
}