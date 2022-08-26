            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloections
{
    public interface IComparer  
    {
         //x가 y보다 크면 1, 같으면 0, 작으면 -1을 반환하는 것으로 약속된 메서드
         int Compare(object x, object y);
    }
}
