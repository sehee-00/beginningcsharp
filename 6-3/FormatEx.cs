using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class FormatEx
    {
        static void Main(String[] args)
        {
            string str = "Hello";

            Console.WriteLine(str + " == HELLO: " + (str == "HELLO"));
            Console.WriteLine(str + " == HELLO: " + str.Equals("HELLO", StringComparison.OrdinalIgnoreCase));

            string txt = "Hello {0} : {1}";

            string output = string.Format(txt, "World", "Anderson");
            Console.WriteLine(output);

            string txt2 = "{2} {0} == {0} : {1}";
            Console.WriteLine(txt2, "Hello", "World", "Hi");

            string txt3 = "{0} * {1} == {2}";
            Console.WriteLine(txt3, 5, 6, 5 * 6);

            string txt4 = "{0, -10} * {1} == {2, 10}";
            Console.WriteLine(txt4, 5, 6, 5 * 6);

            string txt5 = "날짜 : {0, -20:D}, 판매 수량 : {1, 15:N}";
            Console.WriteLine(txt5, DateTime.Now, 267);
        }
    }
}
