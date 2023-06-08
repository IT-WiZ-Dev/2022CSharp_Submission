using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ans = 30;
            int min = 0;
            int max = 100;
            int x;
            int n = 1;
            while(true)
            {
                Console.Write(min + "から" + max + "の間の数値を当ててください。＞ ");
                x = int.Parse(Console.ReadLine());
                if (x < min || max < x)
                {
                    Console.Write("入力値が正しくありません。再入力してください。");
                }
                else if (ans == x)
                {
                    Console.Write("おめでとう。" + n + "回目で当たりました。");
                    break;
                }
                else if (ans < x)
                {
                    Console.WriteLine("答はもっと小さいです");
                    max = x - 1;
                    n++;
                }
                else
                {
                    Console.WriteLine("答はもっと大きいです");
                    min = x + 1;
                    n++;
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
