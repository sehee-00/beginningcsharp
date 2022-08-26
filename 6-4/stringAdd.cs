using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class stringAdd
    {
        static void Main(string[] args)
        {
            /* string txt = "Hello World";
             StringBuilder sb = new StringBuilder();
             sb.Append(txt);

             for(int i =0; i < 300000; i++)
             {
                 sb.Append("1");
             }

             string newText = sb.ToString();
             Console.WriteLine(newText);*/

            var x = Convert.ToChar(Console.ReadLine());
            int ascii = Convert.ToInt32(x);
            Console.WriteLine(ascii);

        }
    }
}
