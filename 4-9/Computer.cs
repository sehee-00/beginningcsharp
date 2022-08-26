using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Computer
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class NoteBook : Computer
{
    bool fingerScan;
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if(powerOn == true)
        {
            Shutdown(); //Notebook에 추가된 메서드 내에서 부모의 메서드 호출
        }
        
    }
}

public class Desktop : Computer { }
public class Netbook : Computer { }

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}

namespace _4_9
{
    class Program
    {
        static void Main(string[] args) 
        {
            NoteBook noteBook1 = new NoteBook();
            noteBook1.Boot();    //Notebook 인스턴스에 대헤 부모의 메서드 호출
            Computer pc = noteBook1; //부모 타입으로 암시적 형변환

            NoteBook noteBook2 = (NoteBook)pc;  //다시 본래 타입으로 명시적 형변환
            noteBook2.CloseLid();

            //140
            NoteBook notebook = new NoteBook();
            Desktop desktop = new Desktop();
            Netbook netbook = new Netbook();

            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);

            //4-11
            Computer[] machines = new Computer[] { new NoteBook(), new Desktop(), new Netbook() };

            foreach(Computer device in machines)
            {
                manager.TurnOff(device);
            }
        }
    }
}
