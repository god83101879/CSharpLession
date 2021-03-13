using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace hw1
{
    public class tool
    {
        public static void MoveFile(string sourcefile, string targetfile) //移動檔案，並在移動的時候檢查目標資料夾是否存在同名檔案，如果有則改名後存放
        {
            if (!File.Exists(sourcefile))
            {
                Console.WriteLine("${sourcefile} 路徑無同名檔案");
                return;
            }
            else if (File.Exists(targetfile))
            {
                Console.WriteLine("${targetfile} 路徑已存在相同名稱檔案，是否更名後搬移? Y/N");
                string YN = Console.ReadLine();
                if (YN.ToUpper() == "N" || YN.ToUpper() == "NO") //ToUpper將小寫字母轉換成大寫
                {
                    Console.WriteLine("結束程式，按任意鍵繼續");
                    return;
                }
                else if (YN.ToUpper() == "Y" || YN.ToUpper() == "YES")
                {
                    Console.WriteLine("請輸入要重新更改的檔案名稱");
                    string nfilename = Console.ReadLine();
                    Console.WriteLine("搬移中...");
                    DateTime starTime = DateTime.Now; //紀錄現在搬移時間=開始時間
                    string Newname = Path.GetDirectoryName(targetfile) + "\\" + Path.GetFileNameWithoutExtension(nfilename) + Path.GetExtension(targetfile); //第一個GET為取得檔案所在的前面路徑，第二個GET為取得檔名，第三個GET為取得副檔名
                    if (File.Exists(Newname))
                    {
                        do
                        {
                            Newname = Path.GetDirectoryName(Newname) + "\\" + Path.GetFileNameWithoutExtension(nfilename) + Path.GetExtension(Newname);
                        } while (File.Exists(Newname));
                    }
                    File.Move(sourcefile, Newname);
                    DateTime endTime = DateTime.Now; // 紀錄現在時間結束時間
                    TimeSpan ts = endTime - starTime;
                    Console.WriteLine($"已移動檔案至{Newname}，共花費{ts.TotalSeconds}秒，按任意鍵繼續");
                }
                else
                    Console.WriteLine("未輸入正確指令，結束程式，按任意鍵繼續");
            }
            else
            {
                Console.WriteLine($"{targetfile} 確定將檔案移入? Y/N");
                string YN = Console.ReadLine();
                if (YN.ToUpper() == "N" || YN.ToUpper() == "NO")
                {
                    Console.WriteLine("已結束程式，按任意鍵繼續");
                    return;
                }
                else if (YN.ToUpper() == "Y" || YN.ToUpper() == "YES")
                {
                    Console.WriteLine("移動中...");
                    DateTime starTime = DateTime.Now;
                    File.Move(sourcefile, targetfile);
                    DateTime endTime = DateTime.Now;
                    TimeSpan ts = endTime - starTime;
                    Console.WriteLine($"已移動檔案至{targetfile}，共花費{ts.TotalSeconds}秒，按任意建繼續");
                }
                else
                    Console.WriteLine("未輸入正確指令，已結束程式，按任意鍵繼續");
            }
        }
    }
}
