using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week
{
    class Program
    {
        // 定義WeekDays 列舉內容七個成員，用來表示一星期的星期日到星期六的列舉常數值
        enum WeekDays : int
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
        struct Product
        {
            public string pnum, pname;
            public int pprice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"星期三列舉常數值:{(int)WeekDays.Wednesday}");
            Console.WriteLine($"星期五列舉常數值:{(int)WeekDays.Friday}");
            Product xbox;
            Console.Write("請輸入Xbox產品編號:");
            xbox.pnum = Console.ReadLine();
            Console.Write("請輸入Xbox產品名稱:");
            xbox.pname = Console.ReadLine();
            Console.Write("請輸入Xbox產品價格:");
            xbox.pprice = int.Parse(Console.ReadLine());
            Product PS;
            Console.Write("請輸入PS產品編號:");
            PS.pnum = Console.ReadLine();
            Console.Write("請輸入PS產品名稱:");
            PS.pname = Console.ReadLine();
            Console.Write("請輸入PS產品價格:");
            PS.pprice = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("======產品單價清單======");
            Console.WriteLine("");
            Console.WriteLine($"產品編號:{xbox.pnum}");
            Console.WriteLine($"產品名稱:{xbox.pname}");
            Console.WriteLine($"產品價格:{xbox.pprice}");
            Console.WriteLine($"產品編號:{PS.pnum}");
            Console.WriteLine($"產品名稱:{PS.pname}");
            Console.WriteLine($"產品價格:{PS.pprice}");
            Console.Read();
        }
    }
}
