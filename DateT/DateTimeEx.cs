using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace _6_1
{
    //p.370~5
    class DateTimeEx
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            Console.WriteLine(now);
            Console.WriteLine(today);

            DateTime before = DateTime.Now;
            Sum();
            DateTime after = DateTime.Now;

           long gap = after.Ticks - before.Ticks;
            Console.WriteLine("Totla TIcks : " + gap);
            Console.WriteLine("Millisecond : " + (gap / 10000));
            Console.WriteLine("Second : " + (gap / 10000 / 1000));

            Console.WriteLine(now + ": " + now.Kind);

            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow + ": " + utcNow.Kind);

            DateTime worldcup2002 = new DateTime(2002, 5, 31);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            worldcup2002 = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Local);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            //밀리초 단위의 시간
            Console.WriteLine(DateTime.UtcNow.Ticks / 10000);

            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            Console.WriteLine("오늘 날짜 : " + now);

            TimeSpan gaps = endOfYear - now;
            Console.WriteLine("올해의 남은 날짜 : " + gaps.TotalDays);

            //특정 구간에 대한 성능을 측정할 때 사용
            Stopwatch st = new Stopwatch();

            st.Start();
            Sum();
            st.Stop();
            Console.WriteLine();
            Console.WriteLine("Total Ticks : " + st.ElapsedTicks);
            Console.WriteLine("millisecond : " + (st.ElapsedTicks / 10000));
            Console.WriteLine("Second : " + (st.ElapsedTicks / 10000 / 1000));

        }

        private static long Sum()
        {
            long sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }

            return sum;
        }

    }
}
