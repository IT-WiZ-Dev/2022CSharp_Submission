using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            do
            {
                Console.Write("整数値＞ ");
                n = int.Parse(Console.ReadLine());
                sum += n;
            } while (n > 0);    // 入力した値が0より大きければ繰り返す
            Console.WriteLine($"合計値は{sum}です。");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
