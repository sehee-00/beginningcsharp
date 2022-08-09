using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hardware { }
class USB
{
    string name;
    public USB(string name)
    {
        this.name = name;
    }
}
class NoteBook : Hardware, IEnumerable  // IEnumerable 인터페이스 구현
{
    USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };
    public IEnumerator GetEnumerator()  //IEnumerator를 구현한 열거자 인스턴스 반환
    {
        return new USBEnumerator(usbList);
    }

    public class USBEnumerator : IEnumerator //중첩 클래스로 정의된 열거자 타입
    {
        int pos = -1;
        int length = 0;
        object[] list;

        public USBEnumerator(USB[] usb)
        {
            list = usb;
            length = usb.Length;
        }

        public object Current { get { return list[pos]; } } //현재 요소를 반환하도록 약속된 접근자 메서드
        public bool MoveNext() { if (pos >= length - 1) { return false; } pos++; return true; }    //다음 순서의 요소를 지정하도록 약속된 메서드

        public void Reset() { pos = -1; }   //처음부터 열거하고 싶을 때 호출하면 되는 메서드

    }

    static void Main(String[] args)
    {
        NoteBook notebook = new NoteBook();
        foreach (USB usb in notebook)
        {
            Console.WriteLine(usb);
        }
    }
}
