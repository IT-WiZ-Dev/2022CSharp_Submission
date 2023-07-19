using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1から10まで表示（リスト5-6）
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // ここからページ数の都合で割愛
            // 更新値を2ずつ加算
            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 10から1まで降順に表示
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 3から30まで3おきに表示
            for (int i = 3; i <= 30; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // カウンタ変数はdoubleもOK
            // カウンタ変数をdoubleにすると誤差が伴う可能性あり
            for (double x = 0.1; x <= 1; x += 0.1)
            {
                Console.Write($"{x:F1} ");
            }
            Console.WriteLine();

            // カウンタ変数はintで出力時に10で割る
            // カウンタ変数をintにすると誤差を伴わない
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{(i / 10.0):F1} ");
            }
            Console.WriteLine();

            // forループ中にif文
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            // ここまでページ数の都合で割愛

            // 1から30までで、2で割り切れる整数値を3おきに降順に表示（リスト5-7）
            for (int i = 30; i >= 1; i -= 3)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
