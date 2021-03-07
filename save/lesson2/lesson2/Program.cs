using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App 6");

            int result = MathCore.Add(5,6);
            Console.WriteLine("5+6=" + result);

            Console.ReadLine();
        }

        static void GOGOGO()
        {
            int result = MathCore.Add(5, 6);
        }
    }
}
