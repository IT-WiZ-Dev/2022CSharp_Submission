using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習問題５_１
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***九九の表***");

            // 横の数字を表示
            Console.Write("   ");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i,2} ");
            }
            Console.WriteLine();

            // 表の区切り線を表示
            Console.WriteLine("  ---------------------------");

            // 九九の表を表示
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i,2}|");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i * j,2} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("キーを押して終了します...");
            Console.ReadKey();
        }
    }
}
