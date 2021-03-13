using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class FileWriter
    {
        public static void WriteFile()
        {
            string path = "D:\\desktop\\新增資料夾\\AAA\\AAA.txt";

            string content = "Hello World!" + Environment.NewLine;

            File.WriteAllText(path, content);
        }

        public static void AppendFile()
        {
            string path = "D:\\desktop\\新增資料夾\\AAA\\AAA.txt";

            string content = "Hello World!" + Environment.NewLine;

            File.AppendAllText(path, content);

        }
    }
}
