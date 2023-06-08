using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教科書第5章練習問題_MultiplicationTable_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *");
            Console.WriteLine("   |  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("--------------------------------");

            int val;
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i + "  | ");

                for (int j = 1; j <= 9; j++)
                {
                    val = i * j;
                    System.Console.Write("{0,3}", val.ToString() + " ");
                }
                System.Console.Write("\n");
            }

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
