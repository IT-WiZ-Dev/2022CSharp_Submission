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
            const int answer = 50;
            int num = -1;
            int up = 100;
            int down = 0;
            int n = 0;

            do
            {
                Console.WriteLine(down + "から" + up +"の間の数値を当ててください。＞　");
                num = int.Parse(Console.ReadLine());
                n = n + 1;

                if (num < down || num > up)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }

                if(num < answer)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    //Console.WriteLine((num + 1) + "から" + up + "の間の数値を当ててください。＞　");
                    down = num + 1;
                }
                else if(num > answer)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    up = num - 1;
                }

                
            } while (num != answer);
            Console.WriteLine("おめでとう。" + n + "回目で当たりました。");

            Console.Read();
        }
    }
}
