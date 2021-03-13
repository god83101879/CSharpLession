using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class FileReader
    {
        public void ReadFile()
        {
            string content = File.ReadAllText("D:\\desktop\\新增資料夾\\AAA.txt");
            Console.WriteLine(content);
        }

        public void ReadFile2()
        {
            string content = File.ReadAllText("D:\\desktop\\新增資料夾\\BBB.txt");
            Console.WriteLine(content);
        }
    }
}
