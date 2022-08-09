using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classconversion
{
    public class Currency
    {
        decimal money;
        public decimal Money { get { return money; } }

        public Currency(decimal money)
        {
            this.money = money;
        }

        static void Main(String[] args)
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(100);

            Won won1 = yen;
            //Won won11 = dollar; //암시적 형변환 불가능
            Won won2 = yen;
            Won won22 = (Won)dollar;

            Console.WriteLine(won1);
            Console.WriteLine(won22);
        }
    }
    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Won";
        }
    }
    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Dollar";
        }
        static public explicit operator Won(Dollar dollar)
        {
            return new Won(dollar.Money * 1000m);
        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Yen";
        }

        static public implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 13m);
        }

    }

}
