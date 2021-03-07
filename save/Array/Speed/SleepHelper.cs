using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            //DateTime startTime = DateTime.Now;
            Console.WriteLine("Program start.");
            sw.Start();
            SleepHelper.SleepAWhile(rnd.Next(5,20));
            sw.Stop();

            sw.Reset();

            sw.Start();
            SleepHelper.SleepAWhile(6);
            sw.Stop();

            //DateTime endTime = DateTime.Now;
            //TimeSpan ts = endTime - startTime;

            //Console.WriteLine("Program End. Total use" + ts.TotalMilliseconds);
            Console.WriteLine("Program End. Total use" + (sw.ElapsedMilliseconds+));
            Console.ReadLine();
        }
    }
    class SleepHelper
    {
        public static void SleepAWhile(int second)
        {
            int ms = second * 1000;
            
            System.Threading.Thread.Sleep(ms);
        }
    }
}
