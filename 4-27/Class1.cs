using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_27
{
    [Flags]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday = 4, Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine(workingDays.HasFlag(Days.Saturday));

            Days today = Days.Friday;
            Console.WriteLine(workingDays.HasFlag(today));

            Console.WriteLine(workingDays);
            /* Days today = Days.Sunday;
            Console.WriteLine(today);*/
        }
    }
}
