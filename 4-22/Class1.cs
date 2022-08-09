using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_22
{
    class SortObject    //배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;

        public SortObject(int[] numbers)    //배열을 생성자의 인자로 받아서 보관
        {
            this.numbers = numbers;
        }
        public delegate bool CompareDelegate(int arg1, int arg2);
        //비교하는 코드를 외부에서 선택하도록 델리게이트로 만드는 방법
        public void Sort(CompareDelegate comparemethod)
        {
            int temp;
            for (int i = 0; i < numbers.Length; i++) 
            {
                int lowPos = i; 
                for (int j = i + 1; j < numbers.Length; j++)  
                {
                    if(comparemethod(numbers[j], numbers[lowPos]))  
                    {  
                        lowPos = j; 
                    }
                }

                temp = numbers[lowPos]; //temp에 작은 값인 lowPos값을 저장
                numbers[lowPos] = numbers[i];   //가장작은 변수 값에 현재 배열 i번째 저장
                numbers[i] = temp;  // i번째 변수에 가장 작은 값을 저장한 변수 temp를 저장 
            }
            
        }

        public void Sort()  //전형적인 선택 정렬 알고리즘을 구현한 메서드
        {                   //numbers 배열의 요소를 크기순으로 정렬
            int temp;
            for(int i=0; i<numbers.Length; i++) //전달받은 배열의 크기만큼 반복함
            {
                int lowPos = i; //오름차순 배열 정렬을 위한 변수 
                for(int j =i+1; j<numbers.Length; j++)  //i번째 배열과 다음 배열 비교
                {
                    if (numbers[j] < numbers[lowPos])   //j번째 배열이 lowPos보다 작은경우
                    {
                        lowPos = j; //lowPos에 j저장
                    }
                }

                temp = numbers[lowPos]; //temp에 작은 값인 lowPos값을 저장
                numbers[lowPos] = numbers[i];   //가장작은 변수 값에 현재 배열 i번째 저장
                numbers[i] = temp;  // i번째 변수에 가장 작은 값을 저장한 변수 temp를 저장 
            }
        }

        public void Display()
        {
            for(int i=0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.Sort();
            so.Display(); Console.WriteLine();

            so.Sort(AscendingCompare);  //오름차순 정렬을 할 수 있는 메서드 전달
            so.Display();

            Console.WriteLine();

            so.Sort(DescendingCompare); //내림차순 정렬을 할 수 있는 메서드 전달
            so.Display();
        }
        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }
        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }
}
