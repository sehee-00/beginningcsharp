using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class StringEx
    {
        static void Main(string[] args)
        {
            string txt = "Hello World";

            //문자열 포함 여부
            Console.WriteLine(txt + " Contains(\"Hello\") : " + txt.Contains("Hello"));
            Console.WriteLine(txt + " Contains(\"Halo\"): " + txt.Contains("Halo"));
            Console.WriteLine();
            //문자열로 끝이 나는지
            Console.WriteLine(txt + " EndsWith(\"World\"): " + txt.EndsWith("World"));
            Console.WriteLine(txt + " EndsWith(\"ello\"): " + txt.EndsWith("ello"));
            Console.WriteLine();
            //문자열 해시값 반환
            Console.WriteLine(txt + " GetHashCode(): " + txt.GetHashCode());
            Console.WriteLine("Hello GetHashCode() : "+ "Hello".GetHashCode());
            Console.WriteLine();
            //문자열 위치 반환, 없으면 -1
            Console.WriteLine(txt + "IndexOf(\"World\"); " + txt.IndexOf("World"));
            Console.WriteLine(txt + "IndexOf(\"Halo\"); " + txt.IndexOf("Halo"));
            Console.WriteLine();
            //문자 대체 
            Console.WriteLine(txt + " Replace(\"World\", \"\"): " + txt.Replace("World", ""));
            Console.WriteLine(txt + " Replace('o', 't'): " + txt.Replace('o','t'));
            Console.WriteLine();

            Console.Write(txt + " Split('o'): ");
            OutputArrayString(txt.Split('o'));
            Console.Write(txt + " Split(' '): ");
            OutputArrayString(txt.Split(' '));
            Console.WriteLine();


            Console.WriteLine(txt + " StartsWith(\"Hello\") : " + txt.StartsWith("Hello"));
            Console.WriteLine(txt + " StartsWith(\"ello\") : " + txt.StartsWith("ello"));
            Console.WriteLine();

            Console.WriteLine(txt + " Substring(1) : " + txt.Substring(1));
            Console.WriteLine(txt + " Substring(2,3) : " + txt.Substring(2,3));
            Console.WriteLine();

            Console.WriteLine(txt + " ToLower() : " + txt.ToLower());
            Console.WriteLine(txt + " ToUpper() : " + txt.ToUpper());
            Console.WriteLine();

            Console.WriteLine("\" Hello World \" Trim(): " + "Hello World".Trim());
            Console.WriteLine(txt + " Trim('H'): "+txt.Trim('H'));
            Console.WriteLine(txt + " Trim('d'): " + txt.Trim('d'));
            Console.WriteLine(txt + " Trim('H', 'd'): " + txt.Trim('H','d'));
            Console.WriteLine();

            Console.WriteLine(txt + " Length : " + txt.Length);
            Console.WriteLine("Hello Length" + "Hello".Length);
            Console.WriteLine();

            Console.WriteLine("Hello != World" + ("Hello" != "World "));
            Console.WriteLine("Hello == World" + ("Hello" == "World "));
            Console.WriteLine("Hello == HELLO" + ("Hello" == "HELLO "));
            Console.WriteLine();

            Console.WriteLine("============================================");
            Console.WriteLine(txt + " EndsWith(\"WORLD\"): " + txt.EndsWith("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " IndexOf(\"WORLD\"): " + txt.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " StartWith(\"HELLO\"): " + txt.StartsWith("HELLO", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();
        }

        private static void OutputArrayString(string[] arr)
        {
            foreach(string txt in arr)
            {
                Console.Write(txt + ", ");
            } 
            Console.WriteLine();
        }
    }
}