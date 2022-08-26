using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_17
{
    class FileText
    {
        static void Main(string[] args)
        {
            /* 예제 6-9
             * 메모리 스트림을 이용함
            MemoryStream ms = new MemoryStream();

            StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
            sw.WriteLine("Hello World!");
            sw.WriteLine("Anderson");
            sw.WriteLine(32000);
            sw.Flush();

            ms.Position = 0;
            StreamReader sr = new StreamReader(ms, Encoding.UTF8);
            string txt = sr.ReadToEnd();
            Console.WriteLine(txt);
            */

            /*StreamWriter를 사용한 예제
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                StreamWriter sww = new StreamWriter(fs, Encoding.UTF8);
                sww.WriteLine("Hello World!");
                sww.WriteLine("Anderson");
                sww.WriteLine(32000);
                sww.Flush();
            }*/

            /* 예제 6-10 dml FileStream 버전
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Hello World" + Environment.NewLine);
                bw.Write("Anderson" + Environment.NewLine);
                bw.Write(32000);
                bw.Flush();
            }*/

            /*
            using (FileStream fs = new FileStream("test.log", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write("Hello World");
                Console.ReadLine();
            }
            */
            using (FileStream fs = new FileStream("test.log", FileMode.Append, FileAccess.Write, FileShare.None))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write("Hello World");
                Console.ReadLine();
            }

        }
        


    }
}
