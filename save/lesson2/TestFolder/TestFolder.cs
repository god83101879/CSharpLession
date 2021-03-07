using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFolder
{
    class TestFolder
    {
        public static void ListAllFile(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;
            }

            string[] folderItems = Directory.GetFileSystemEntries(path);

            foreach (string item in folderItems)
            {
                Console.WriteLine(item);
            }
        }

    }
}
