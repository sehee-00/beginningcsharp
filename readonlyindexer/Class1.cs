using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonlyindexer
{
    class Notebook
    {
        int inch;
        int memory6B;

        public Notebook(int inch, int memory6B)
        {
            this.inch = inch;
            this.memory6B = memory6B;
        }
        
        public int this[string propertyName]    //문자열로 인덱스를 지정
        {
            get
            {
                switch (propertyName)
                {
                    case "인치":
                        return inch;

                    case "메모리크기":
                        return memory6B;
                }

                return -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook normal = new Notebook(13, 4);

            Console.WriteLine("모니터 인치 : " + normal["인치"] + "\"");
            Console.WriteLine("메모리 크기 : " + normal["메모리크기"] + "GB"); 
        }
    }
}
