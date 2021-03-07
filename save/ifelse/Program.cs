using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int age;
            Console.Write("請輸入年齡:");
            age = int.Parse(Console.ReadLine());
            if (age < 10 || age > 19)
                Console.Write($"你的年齡是{age}, 不是青少年");
            else
                Console.Write($"你的年齡是{age}, 是青少年");
            Console.Read();*/

            /*int k = 10;
            if (k != 0)
                Console.WriteLine("結果不等於零");
            Console.Read();*/

            /*int n1, n2, n3, max=0;
            Console.Write("1. 請輸入第一個數值:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2. 請輸入第二個數值:");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("3. 請輸入第三個數值:");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
                max = n1;
            if (n2 > n1 && n2 > n3)
                max = n2;
            if (n3 > n1 && n3 > n2)
                max = n3;
            Console.Write($"\n 三者數值最大值為:{max}");
            Console.Read();*/

            /*int ans;
            Console.WriteLine("試問Visual Studio可開發下列哪種應用程式?");
            Console.WriteLine("1.視窗程式 2.Web程式 3.裝置應用程式 4.以上皆是");
            Console.Write("請作答:");
            ans = int.Parse(Console.ReadLine());
            if (ans == 4)
                Console.WriteLine("答對了，真不愧是.NET達人");
            else if (ans == 1 || ans == 2 || ans == 3)
                Console.WriteLine("答錯了，正確答案是4");
            else
                Console.WriteLine("無此選項");
            Console.Read();*/

            /*int i = 10;
            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine($"{i}為 奇數");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine($"{i}為 偶數");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            Console.Read();*/

            /*Console.WriteLine("試問Visual Studio可開發下列哪種應用程式\n");
            Console.WriteLine(" 1.視窗程式 2.Web程式 3.裝置應用程式 4.以上皆可\n");
            Console.Write("請作答:");

            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                case "2":
                case "3":
                    Console.WriteLine("\n 答錯了 正確答案是4");
                    break;
                case "4":
                    Console.WriteLine("\n 答對了 真不愧是.NET達人");
                    break;
                default:
                    Console.WriteLine("無此選項");
                    break;
            }
            Console.Read();*/

            /*double netIncome = 0, taxRate = 0,tax=0;
            int discount = 0, stage = 0;

            Console.WriteLine("\n 請輸入全年綜合所得淨額(元)：");
            netIncome = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (netIncome > 0)
                stage = (netIncome <= 520000 ? 1 : (netIncome <= 1170000 ? 2 : (netIncome <= 2350000 ? 3 :
                    (netIncome <= 4400000 ? 4 : (netIncome <= 10000000 ? 5 : 6)))));
            else
                Console.WriteLine("全年所得淨額為負! 不用繳稅");

            switch (stage)
            {
                case 1:
                    taxRate = 0.05;
                    discount = 0;
                    tax = netIncome * taxRate - discount;
                    break;
                case 2:
                    taxRate = 0.12;
                    discount = 36400;
                    tax = netIncome * taxRate - discount;
                    break;
                case 3:
                    taxRate = 0.2;
                    discount = 130000;
                    tax = netIncome * taxRate - discount;
                    break;
                case 4:
                    taxRate = 0.3;
                    discount = 365000;
                    tax = netIncome * taxRate - discount;
                    break;
                case 5:
                    taxRate = 0.4;
                    discount = 805000;
                    tax = netIncome * taxRate - discount;
                    break;
                case 6:
                    taxRate = 0.45;
                    discount = 1305000;
                    tax = netIncome * taxRate - discount;
                    break;
                default:
                    Console.WriteLine("無此級距");
                    break;
            }
            Console.WriteLine($"\n 1.綜合淨所得:{netIncome:C}元");
            Console.WriteLine($"\n 2.所得稅級距:第{stage}級");
            Console.WriteLine($"\n 3.累進稅率:{taxRate * 100}%");
            Console.WriteLine($"\n 4.累進差額:{discount:C}元");
            Console.WriteLine($"\n 5.應繳稅額:{tax:C}元");
            Console.Read();*/

            /*
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}Δ");
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {
                Console.Write($"{i}Δ");
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {
                if (i == 3)
                    break;
                Console.Write($"{i}Δ");
            }
            Console.Read();
            */

            /*string pass="";
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("請輸入密碼:");
                pass = Console.ReadLine();

                if (pass == "best") 
                { 
                    Console.WriteLine("登入成功，歡迎進入本系統");
                    break;
                }

                else if (i == 3)
                {
                    Console.WriteLine("非法進入!!");
                    break;
                }
                else
                    Console.WriteLine($"Sorry!密碼輸入{i}次，請重新輸入");
                Console.WriteLine();
            }
            Console.Read();*/
            /*
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= i; k++)
                    Console.Write($"  {k}");
                Console.WriteLine();
            }
            Console.Read();*/

            /*int factor, testNo = 0, count = 0;
            Console.Write("請輸入欲求因數的數值(1-50):");
            factor = int.Parse(Console.ReadLine());

            if (factor >= 1 && factor <= 50)
            {
                Console.WriteLine($"\n 求1到100能被{factor}整除的因數 \n");
                testNo = 0;
                while (true)
                {
                    testNo = testNo + factor;
                    if (testNo <= 100)
                    {
                        count = count + 1;
                        Console.Write($"{testNo} ,");
                        if ((count % 5) == 0)
                            Console.WriteLine();
                    }
                    else
                        break;
                }
                Console.WriteLine($"由1到100共有{count}個整數可被{factor}整除");
            }
            else
                Console.WriteLine("輸入的資料超出範圍");

            Console.ReadLine();*/

            /*string yes = "";
            int score, sum=0, count=0;
            Console.WriteLine("成績試算");
            do
            {
                count = count + 1;
                Console.Write($" {count}. 請輸入第{count}位同學的成績:");
                score = int.Parse(Console.ReadLine());
                sum = sum + score;
                Console.Write(" 是否繼續? (Y/N) :");
                yes = Console.ReadLine();
            } while (yes == "y" || yes == "Y");

            Console.WriteLine($"共輸入{count}位同學成績, 班上平均成績:{sum / count}");
            Console.Read();*/

            /*int sum = 0, upper = 0, n=0; //n為連加的總和
            Console.WriteLine(" 求 +1+2+3+.....+N <=Upper(臨界值)");
            Console.Write("1.請輸入Upper(臨界值):");
            upper = int.Parse(Console.ReadLine());
            do
            {
                n = n + 1;
                if (sum <= upper)
                {
                    sum += n;
                    continue;
                }
                else
                {
                    sum = sum - n +1;
                    break;
                }
            } while (n > 0);
            Console.WriteLine($"2.電腦自動算出N(終值):{n - 2}");
            Console.WriteLine($"3. 1 + 2 +3 + ...... + {n - 2}={sum}");
            Console.Read();*/


        }
    }
}
