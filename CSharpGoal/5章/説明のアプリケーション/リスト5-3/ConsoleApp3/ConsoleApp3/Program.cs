using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            string s = "こんにちは";
            Console.WriteLine("{0}、aの値は{1}です。", s, a);
            Console.WriteLine($"{s}、aの値は{a}です。");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
