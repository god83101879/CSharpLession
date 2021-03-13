using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int upper = 100, lower = 1, gue = 0, count = 0;
            Random r = new Random();
            int ans = r.Next(1, 100);

            Console.Write("猜數字遊戲開始"); 
            Console.Write("請輸入你想猜的數字(1~100):");
            do
            {
                count = count + 1;
                gue = int.Parse(Console.ReadLine());
                if (gue <= lower || gue >= upper)
                {
                    Console.WriteLine("幹你的別亂猜");
                    Console.ReadLine();
                }
                if (ans == gue)
                {
                    Console.Write($"恭喜你猜中數字,共猜了{count}次");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (gue >= lower && gue <= upper && ans >= gue)
                    {
                        lower = gue;
                        Console.Write($"猜數字範圍 {lower} < ? < {upper} 所猜數字:{gue} \n 再大一點 :");
                    }
                    if (gue >= lower && gue <= upper && ans <= gue)
                    {
                        upper = gue;
                        Console.Write($"猜數字範圍 {lower} < ? < {upper} 所猜數字:{gue} \n 再小一點 :");
                    }
                }

            } while (ans != gue && gue>=lower && gue<=upper);

        }
    }
}
