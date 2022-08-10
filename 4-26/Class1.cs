using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_26
{
    enum Days
    { 
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Sunday;
            Console.WriteLine(today);
        }
    }
}
