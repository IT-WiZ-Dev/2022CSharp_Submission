using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5行7列の*を表示（リスト5-8）
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            // *を行の数だけ表示（リスト5-9）
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            // ここからページ数の都合で割愛
            // *を1行ごとに減らして表示
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= (6 - i); j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");

            // *で2等辺三角形を表示
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
            Console.Write("\n\n");

            // *で5行4列の長方形を3個表示
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");

                }
                Console.Write("\n");
            }
            Console.Write("\n");
            // ここまでページ数の都合で割愛


            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
