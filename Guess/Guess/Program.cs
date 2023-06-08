
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
            int ans = 75;
            int count = 1;
            bool flag = false;
            while (flag == false)
            {
                Console.Write("0から100の間の数値を当ててください。＞");
                Console.Write('\n');
                int uesr = int.Parse(Console.ReadLine());
                if (uesr == ans)
                {
                    Console.Write("おめでとう！{0}回目であたりました", count);
                    Console.Write('\n');
                    flag = true;
                }
                else if (uesr > ans)
                {
                    Console.Write("答はもっと小さいです。");
                    Console.Write('\n');
                    count++;
                    continue;
                }
                else
                {
                    Console.Write("答はもっと大きいです");
                    Console.Write('\n');
                    count++;
                    continue;
                }
            }
        }
    }
}
