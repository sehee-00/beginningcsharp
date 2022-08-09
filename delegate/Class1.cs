using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diskdelegate
{
    public class Disk
    {
        public int Clean(object arg)
        {
            Console.WriteLine("작업 실행");
            return 0;
        }
        delegate int FuncDelegate(object arg);

        static void Main(String[] args)
        {
            Disk disk = new Disk();

            FuncDelegate cleanFunc = disk.Clean;

            disk.Clean(null);
            cleanFunc(null);
        }
    }
}
