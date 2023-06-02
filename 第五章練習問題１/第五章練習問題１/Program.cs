using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章練習問題１
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 九九の表 ***");

            // 横の数字を表示
            Console.Write("  ");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();

            // 表の区切り線を表示
            Console.WriteLine("---------------------------");

            // 九九の表を表示
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i}|");
                for (int j = 1; j <= 9; j++)
                {
                    int result = i * j;
                    Console.Write($"{result,2} ");
                }
                Console.WriteLine();
            }

        }
    }
}
