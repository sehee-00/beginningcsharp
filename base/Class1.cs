using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingbase
{
    
    public class Computer
    {
        virtual public void Boot()
        {
            Console.WriteLine("메인보드 켜기");
        }
        static void Main(String[] args)
        {
            Computer computer = new Computer();
            computer.Boot();

            Notebook notebook = new Notebook();
            notebook.Boot();
        }
    } 
    
    public class Notebook : Computer
    {
        override public void Boot()
        {
            base.Boot();
            Console.WriteLine("액정화면 켜기");
        }
    }
}
