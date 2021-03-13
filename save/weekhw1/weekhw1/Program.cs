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
            string YN = "";
            DateTime startTime = DateTime.Now;
            Console.WriteLine("歡迎進入本系統，是否開始操作? Y/N:");
            YN = Console.ReadLine();
            do
            {
                Console.WriteLine("請輸入操作選項之數字, 1.搬移檔案 2.拷貝檔案 3.讀取檔案 4.刪除檔案 5.建立資料夾 6.刪除資料夾");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        startTime = DateTime.Now;
                        Console.Write("請輸入欲搬移之文件路徑檔名:");
                        string movefile = Console.ReadLine();
                        if (!File.Exists(movefile))                                                   //若無檔案存在則停止
                        {
                            Console.WriteLine($"{movefile} 此路徑檔案不存在");
                            Console.Read();
                            return;
                        }
                        Console.Write("請輸入搬移至路徑及檔名:");
                        string targetfile = Console.ReadLine();
                        if (!File.Exists(movefile))
                        {
                            if (Path.GetFileNameWithoutExtension(movefile) == Path.GetFileNameWithoutExtension(targetfile)) //判斷檔名是否相同
                            {
                                Console.Write("該路徑有相同名稱檔案，是否更改名稱? Y(YES)/N(NO):");
                                string samename = Console.ReadLine();
                                if (samename.ToUpper() == "Y" || samename.ToUpper() == "YES")
                                {
                                    Console.Write("請輸入欲更改之路徑及檔名:");
                                    targetfile = Console.ReadLine();
                                }
                                else if (samename.ToUpper() == "N" || samename.ToUpper() == "NO")
                                {
                                    Console.WriteLine("已結束程式");
                                    Console.Read();
                                    return;
                                }
                            }
                        }
                        Console.Write("確定要移動檔案? Y(YES)/N(NO):");
                        string finalans = Console.ReadLine();
                        if (finalans.ToUpper() == "Y" || finalans.ToUpper() == "YES")
                        {
                            File.Move(movefile, targetfile);  //移動檔案C到D
                            Console.WriteLine($"已將檔案{movefile}移動至指定路徑{targetfile}");
                        }
                        else if (finalans.ToUpper() == "N" || finalans.ToUpper() == "NO")
                        {
                            Console.WriteLine($"程式結束");
                            Console.Read();
                            return;
                        }
                        DateTime endTime = DateTime.Now;
                        TimeSpan ts = endTime - startTime;
                        Console.WriteLine($"共花費{ts.TotalSeconds}秒");
                        Console.ReadLine();
                        break;
                    case 2:
                        startTime = DateTime.Now;
                        Console.Write("請輸入欲複製之文件路徑檔名:");
                        string copyfile = Console.ReadLine();
                        if (!File.Exists(copyfile))                                                   //若無檔案存在則停止
                        {
                            Console.WriteLine($"{copyfile} 此路徑檔案不存在");
                            Console.Read();
                            return;
                        }
                        Console.Write("請輸入複製目標路徑及檔名:");
                        targetfile = Console.ReadLine();
                        Console.Write("確定要複製檔案? Y(YES)/N(NO):");
                        finalans = Console.ReadLine();
                        if (finalans.ToUpper() == "Y" || finalans.ToUpper() == "YES")
                        {
                            File.Copy(copyfile, targetfile, true);  //複製檔案C到D
                            Console.WriteLine($"已將檔案{copyfile}複製至指定路徑{targetfile}");
                        }
                        else if (finalans.ToUpper() == "N" || finalans.ToUpper() == "NO")
                        {
                            Console.WriteLine($"程式結束");
                            Console.Read();
                            return;
                        }
                        endTime = DateTime.Now;
                        ts = endTime - startTime;
                        Console.WriteLine($"共花費{ts.TotalSeconds}秒");
                        Console.ReadLine();
                        break;
                    case 3:
                        startTime = DateTime.Now;
                        Console.Write("請輸入欲讀取之文件路徑檔名:");
                        string readfile = Console.ReadLine();
                        if (!File.Exists(readfile))                                                   //若無檔案存在則停止
                        {
                            Console.WriteLine($"{readfile} 此路徑檔案不存在");
                            Console.Read();
                            return;
                        }
                        Console.Write("確定要讀取檔案? Y(YES)/N(NO):");
                        finalans = Console.ReadLine();
                        if (finalans.ToUpper() == "Y" || finalans.ToUpper() == "YES")
                        {
                            string fileName = File.ReadAllText(readfile); //讀取檔案顯示到DOS視窗
                            Console.WriteLine(fileName);
                            Console.WriteLine($"已讀取檔案{readfile}");
                        }
                        else if (finalans.ToUpper() == "N" || finalans.ToUpper() == "NO")
                        {
                            Console.WriteLine($"程式結束");
                            Console.Read();
                            return;
                        }
                        endTime = DateTime.Now;
                        ts = endTime - startTime;
                        Console.WriteLine($"共花費{ts.TotalSeconds}秒");
                        Console.Read();
                        break;
                    case 4:
                        startTime = DateTime.Now;
                        Console.Write("請輸入欲刪除之文件路徑檔名:");  //輸入刪除檔名即可刪除檔案
                        string orderfile = Console.ReadLine();
                        if (!File.Exists(orderfile))                                                   //若無檔案存在則停止
                        {
                            Console.WriteLine($"{orderfile} 此路徑檔案不存在");
                            Console.Read();
                            return;
                        }
                        Console.Write("確定要刪除檔案? Y(YES)/N(NO):");
                        finalans = Console.ReadLine();
                        if (finalans.ToUpper() == "Y" || finalans.ToUpper() == "YES")
                        {
                            File.Delete(orderfile); //刪除檔案
                            Console.WriteLine($"已刪除{orderfile}檔案");
                        }
                        else if (finalans.ToUpper() == "N" || finalans.ToUpper() == "NO")
                        {
                            Console.WriteLine($"程式結束");
                            Console.Read();
                            return;
                        }
                        endTime = DateTime.Now;
                        ts = endTime - startTime;
                        Console.WriteLine($"共花費{ts.TotalSeconds}秒");
                        Console.Read();
                        break;
                    case 5:
                        startTime = DateTime.Now;
                        Console.Write("請輸入欲建立之路徑資料夾名稱:"); //輸入建立檔名即可建立檔案
                        string foldername = Console.ReadLine();
                        Console.Write("確定要建立資料夾? Y(YES)/N(NO):");
                        finalans = Console.ReadLine();
                        if (finalans.ToUpper() == "Y" || finalans.ToUpper() == "YES")
                        {
                            Directory.CreateDirectory(foldername); //建立資料夾
                            Console.WriteLine($"已建立{foldername}資料夾");
                        }
                        else if (finalans.ToUpper() == "N" || finalans.ToUpper() == "NO")
                        {
                            Console.WriteLine($"程式結束");
                            Console.Read();
                            return;
                        }
                        endTime = DateTime.Now;
                        ts = endTime - startTime;
                        Console.WriteLine($"共花費{ts.TotalSeconds}秒");
                        Console.Read();
                        break;
                    case 6:
                        startTime = DateTime.Now;
                        Console.Write("請輸入欲刪除之資料夾路徑名稱:"); //輸入刪除檔名即可刪除檔案
                        string folderdelete = Console.ReadLine();
                        Console.Write("確定要刪除資料夾? Y(YES)/N(NO):");
                        finalans = Console.ReadLine();
                        if (finalans.ToUpper() == "Y" || finalans.ToUpper() == "YES")
                        {
                            Directory.Delete(folderdelete, true); //刪除資料夾
                            Console.WriteLine($"已刪除{folderdelete}資料夾");
                        }
                        else if (finalans.ToUpper() == "N" || finalans.ToUpper() == "NO")
                        {
                            Console.WriteLine($"程式結束");
                            Console.Read();
                            return;
                        }
                        endTime = DateTime.Now;
                        ts = endTime - startTime;
                        Console.WriteLine($"共花費{ts.TotalSeconds}秒");
                        Console.Read();
                        break;
                }
                Console.WriteLine("是否繼續執行? Y/N:");
                Console.ReadLine();
            } while (YN.ToUpper() == "Y" || YN.ToUpper() == "YES");
            return;
            DateTime EndTime = DateTime.Now;
            TimeSpan Ts = EndTime - startTime;
            Console.WriteLine($"\n已使用本程式共歷時 " + Ts.TotalMilliseconds + " 毫秒.");
        }
    }
}
