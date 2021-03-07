using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class TestFileReader
    {
        public static string ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return string.Empty;
            }

            string content = File.ReadAllText(path);
            return content;
        }

        public static void WriteFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;
            }
            File.WriteAllText(path, content);
        }
        public static void Append(string path, string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;
            }

            string cTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            content = System.Environment.NewLine + "[" + cTime + "]" + content;

            File.AppendAllText(path, content);
        }
    }
}
