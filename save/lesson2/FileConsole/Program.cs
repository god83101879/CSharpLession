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
            string fileName = "AAA.txt";
            try
            {
                string content = TestFileReader.ReadFile(path + fileName);
                //string content = "Hello World!!";
                //TestFileReader.WriteFile(path + fileName, content);
                //TestFileReader.Append(path + fileName, content);
                //TestFolderReader.ListAllFile(path);
                //TestFolderReader.CreateFolder(path + "TempFolder");
                //TestFolderReader.DeleteFolder(path + "TempFolder");

                /*
                string newPath = "D:\\desktop\\新增資料夾\\AAA.txt";
                
                // "D:\\desktop\\新增資料夾\\AAA.txt"
                Console.WriteLine(System.IO.Path.Combine("D:\\desktop\\新增資料夾", "AAA.txt"));
                // D:\\desktop\\新增資料夾
                Console.WriteLine(System.IO.Path.GetDirectoryName(newPath));
                // AAA.txt
                Console.WriteLine(System.IO.Path.GetFileName(newPath));
                */

                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("幹你錯囉");
                Console.ReadLine();
            }




        }
    }
}
