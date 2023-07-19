using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("科目＞ ");
            string subject = Console.ReadLine();
            Console.Write("点数＞ ");
            int score = int.Parse(Console.ReadLine());
            Console.Write("平均点＞ ");
            double average = double.Parse(Console.ReadLine());
            Console.WriteLine($"{subject}は{score}点（平均{average}点）");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
