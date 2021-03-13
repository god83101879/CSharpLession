using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class FolderReader
    {
        public static void ListFolder1()
        {
            string folderPath = "D:\\desktop\\新增資料夾\\";

            string[] array = Directory.EnumerateFiles(folderPath).ToArray();

            Console.WriteLine("Read folder: " + folderPath );

            foreach (string fileName in array)
            {
                Console.WriteLine(fileName);
            }
        }

        public static void ListFolder2()
        {
            string folderPath = "D:\\desktop\\新增資料夾\\BBB.txt";

            string[] array = Directory.EnumerateFiles(folderPath).ToArray();

            Console.WriteLine("Read folder: " + folderPath);

            foreach (string fileName in array)
            {
                Console.WriteLine(fileName);
            }
        }

        public static void AddFolder()
        {
            string folderPath = "D:\\desktop\\新增資料夾\\BBB.txt";

            Directory.CreateDirectory(folderPath);
        }
    }
}
