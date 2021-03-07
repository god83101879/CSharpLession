using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\desktop\\新增資料夾\\";
            //string path = "..\\..\\..\\lesson3\\";
            string fileName = "AAA.txt";

            // string content = TestFileReader.ReadFile(path + fileName);

            //string content = File.ReadAllText(path + fileName);

            string content = "Hello World!!";
            //TestFileReader.WriteFile(path + fileName, content);
            //TestFileReader.Append(path + fileName, content);
            
            //TestFolder.CreateFolder(path + "Temp");
            //TestFolder.DeleteFolder(path + "Temp");
            
            Console.WriteLine(content);
            Console.ReadLine();
            /*
            string newPath = "D:\\desktop\\新增資料夾\\";

            Console.WriteLine(System.IO.Path.Combine("D:\\desktop\\新增資料夾\\", "AAA.txt"));

            Console.WriteLine(System.IO.Path.GetDirectoryName(newPath));

            Console.WriteLine(System.IO.Path.GetFileName(newPath));

            Console.ReadLine();*/
        }
    }
}
