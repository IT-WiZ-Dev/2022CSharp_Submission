/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
} */
using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // 左側の列を表示
            Console.Write("   ");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();

            // テーブルの区切り線を表示
            Console.WriteLine("   ----------------------------------------------");

            // 九九の表を表示するための2重ループ
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i,2}|");

                for (int j = 1; j <= 9; j++)
                {
                    // 乗算の結果を計算し、出力する
                    int result = i * j;
                    Console.Write($"{result,3}");
                }

                // 1行終了後に改行する
                Console.WriteLine();
            }

            // プログラムが終了する前に、コンソールウィンドウを開いたままにするために入力待ちを行う
            Console.ReadLine();
        }
    }
}

