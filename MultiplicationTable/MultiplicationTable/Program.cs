using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *   ");
            Console.WriteLine("   |  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("--------------------------------");
            for (int a = 1; a <= 9; a ++)
            {
                Console.Write(a);
                Console.Write("  |");
                for (int b = 1; b <= 9; b++)
                {
                    int n = 0;
                    n = a * b;
                    Console.Write("{0,3}", n);
                }
                Console.Write('\n');
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
