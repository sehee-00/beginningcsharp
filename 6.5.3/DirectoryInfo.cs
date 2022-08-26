using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5._3
{
    class DirectoryInfo
    {
        static void Main(string[] args)
        {   /*
            foreach(string txt in Directory.GetLogicalDrives())
            {
                Console.WriteLine(txt);
            }
            string targetPath = @"C:\Windows\Microsoft.NET\Framework";
            foreach (string txt in Directory.GetFiles(targetPath))
            {
                Console.WriteLine(txt);
            }
            string tPath = @"C:\Windows\Microsoft.NET\Framework";
            foreach(string txt in Directory.GetDirectories(tPath))
            {
                Console.WriteLine(txt);
            }

            string tP = @"C:\Windows\Microsoft.NET\Framework";
            foreach(string txt in Directory.GetFiles(targetPath, "*.ext", SearchOption.AllDirectories))
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine();
            
            //6-5-4

            string fileP = Path.Combine(@"C:\temp", "test", "myfile.dat");
            Console.WriteLine(fileP);
            */


            //..... include가 계속 -1의 값을 가진다..뭘까
            string newDirName = "my<<<<><><><new";   //폴더명에 '<' 문자는 허용되지 않는다
            int include = newDirName.IndexOfAny(Path.GetInvalidPathChars());
            Console.WriteLine(include);
            if(include != -1)
            {
                Console.WriteLine("폴더명에 적절하지 않은 문자가 있음");
            }

            
            //크기가 0인 임시 파일을 생성하고 그 경로를 반환한다.
            string createdTempFilePath = Path.GetTempFileName();
            Console.WriteLine(createdTempFilePath);

            //임시 파일을 생성하지 않고 중복될 확률이 낮은 임시 파일 경로를 구한다.
            string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Console.WriteLine(tempFilePath);

        }

    }
}
