using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            string s = "こんにちは";
            Console.Write(a);
            Console.WriteLine(s);
            Console.WriteLine(s + "、aの値は" + a + "です。");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
