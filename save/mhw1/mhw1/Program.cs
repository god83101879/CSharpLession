using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入操作選項之數字, 1.搬移檔案 2.拷貝檔案 3.讀取檔案 4.刪除檔案 5.建立資料夾 6.刪除資料夾");
            int ans = int.Parse(Console.ReadLine());
            string fileName = "aaa.txt";
            string source = "C:\\Temp\\";
            string sourceFile = "C:\\Temp\\aaa.txt";
            string targetFile = "D:\\Temp\\aaa.txt";
            switch (ans)
            {
                case 1:
                    Console.WriteLine("請輸入欲搬移之路徑");
                    string movefolder = Console.ReadLine();
                    Console.WriteLine("請輸入欲搬移之檔名");
                    string movefile = Console.ReadLine();
                    /*if (movefile == ans)
                    {
                        
                    }*/
                    File.Move(sourceFile, targetFile);  //移動檔案C到D
                    Console.WriteLine($"已將檔案{fileName}從{sourceFile}移動到{targetFile}");
                    Console.ReadLine();
                    break;

                case 2:
                    File.Copy(sourceFile, targetFile, true); //複製檔案C到D
                    break;
                case 3:
                    fileName = File.ReadAllText(sourceFile); //讀取檔案顯示到DOS視窗
                    Console.WriteLine(fileName);
                    Console.Read();
                    break;
                case 4:
                    Console.Write("請輸入欲刪除之文件檔名:");  //輸入刪除檔名即可刪除檔案
                    string orderfile = Console.ReadLine();
                    File.Delete(source + orderfile);
                    break;
                case 5:
                    Console.Write("請輸入欲建立之資料夾名稱:"); //輸入建立檔名即可建立檔案
                    string foldername = Console.ReadLine();
                    Directory.CreateDirectory(source + foldername);
                    break;
                case 6:
                    Console.Write("請輸入欲刪除之資料夾名稱:"); //輸入刪除檔名即可刪除檔案
                    string foldername2 = Console.ReadLine();
                    Directory.Delete(source + foldername2);
                    break;
            }
      
        }
    }
}
