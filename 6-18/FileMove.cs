using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_18
{
    class FileMove
    {
        static void Main(string[] args)
        {/*
            string target = "c:\\temp\\test.dat";
            if(File.Exists(target) == true)
            {
                File.Delete(target);
            }
            File.Move("test.log", target);
            */
            FileInfo source = new FileInfo("test.log");
            FileInfo t = new FileInfo("c:\\temp\\test.dat");
            if(t.Exists == true)
            {
                t.Delete();
            }
            source.MoveTo(t.FullName);
        }
    }
}
