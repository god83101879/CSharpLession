using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class Copior
    {
        public static void CopyFile()
        {
            string sourcePath = "D:\\desktop\\新增資料夾\\\\AAA.txt";
            string targetPath = "D:\\desktop\\新增資料夾\\\\BBB.txt";

            System.IO.File.Copy(sourcePath, targetPath);
        }
    }
}
