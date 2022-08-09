using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverrode
{
    public class Kilogram
    {
        double mass;
        decimal kg;

        public Kilogram(double value)
        {
            this.mass = value;
        }
        public decimal Kg { get { return kg; } }
        public Kilogram(decimal kg)
        {
            this.kg = kg;
        }
        /*
        public Kilogram Add (Kilogram target)
        {
            return new Kilogram(target.mass + this.mass);
        }
        
        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }*/

        static void Main(String[] args)
        {
            /*Kilogram kg1 = new Kilogram(5.0);
            Kilogram kg2 = new Kilogram(10.0);

            Kilogram kg3 = kg1.Add(kg2);
            Kilogram kg4 = kg1 + kg2;

            Console.WriteLine(kg3);
            Console.WriteLine(kg4);
            */

            ToKg tk = new ToKg(1);
            Gram gram = new Gram(1);

            ToKg gram1 = (ToKg)gram;
            Console.WriteLine(gram1);
            Console.WriteLine(tk);
        }

    }
    public class ToKg : Kilogram {
        public ToKg(decimal kg): base(kg) { }
        public override string ToString()
        {
            return Kg + "kg";
        }
        
    }

    public class Gram : Kilogram
    {
        public Gram(decimal kg) : base(kg) { }
        public override string ToString()
        {
            return Kg + "g";
        }
        static public implicit operator ToKg(Gram gram)
        {
            return new ToKg(gram.Kg * 1000m);
        }
    }
}
