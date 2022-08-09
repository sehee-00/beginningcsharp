using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathodoverrode
{
    class Mathematics
    {
        public int Abs(int value)   //오버로드 지원
        {
            return (value >= 0) ? value : -value;
        }
        public double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }

        public decimal Abs(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
        static void Main(String[] argas)
        {
            Mathematics math = new Mathematics();
            Console.WriteLine(math.Abs(-5));
            Console.WriteLine(math.Abs(-10.052));
            Console.WriteLine(math.Abs(20.01m));
        }
    }
}
