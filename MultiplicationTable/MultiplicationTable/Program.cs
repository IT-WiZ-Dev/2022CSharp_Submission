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
            int rows = 9;
            int columns = 9;
            Console.Write("***九九の表***");
            Console.WriteLine();
            // 横方向のヘッダーを表示
            Console.Write("  |  ");
            for (int i = 1; i <= columns; i++)
            {
                Console.Write("{0,3}", i);
            }
            Console.WriteLine();

            // 横方向のヘッダーの区切り線を表示
            Console.WriteLine("-----------------------------------");

            // 九九の表を作成する
            for (int i = 1; i <= rows; i++)
            {
                // 縦方向のヘッダーを表示
                Console.Write("{0} |", i);

                for (int j = 1; j <= columns; j++)
                {
                    // 九九の計算結果を表示する
                    Console.Write("{0,3}", i * j);
                }
                Console.WriteLine();
            }

           
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
        }
    }

    
        