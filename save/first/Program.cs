using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2,length,data,data2;
            int height = 190, size;
            data2 = "長整數";
            str1 = "黑暗騎士";
            size = 8;
            str2 = str1 + "的身高是" + 189;
            data = string.Format("{0}的身高是{1}", str1, height);
            length = $"{2}個{data2}資料佔{2 * size}位元組記憶空間";

            /*string no1;
            int no2;
            Console.Write("請輸入品名:");
            no1 = Console.ReadLine();
            Console.Write("請輸入單價:");
            no2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"品名:{no1}  單價:{no2}  記錄儲存成功");*/

            Console.WriteLine($"{5,0:C} {-5,0:c3} {-5,15:C3} {-5,-15:C3}");


            Console.WriteLine("Hello World");
            Console.WriteLine("歡迎來到C#的世界");
            Console.WriteLine(str2);
            Console.WriteLine(data);
            Console.WriteLine(length);
            Console.Read();
        }
    }
}
