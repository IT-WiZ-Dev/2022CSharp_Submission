using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.WriteLine("整数値を10回入力してください。");
            Console.WriteLine("途中で負数を入力したら終了します。");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("＞ ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)  // 負数が入力された場合、ループを脱出
                    break;
                sum += n;
            }
            Console.WriteLine($"合計値は{sum}です。");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
