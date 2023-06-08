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
            const int n = 32;
            int a = 0;
            int b = 100;
            Console.WriteLine(a + "から" + b +"の間の数値を当ててください。>");
            int score = int.Parse(Console.ReadLine());
            int count = 1;
            while(n != score)
            {
                if(score > b || a < 0 || score < a)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                else
                {
                    if(n < score)
                    {
                        Console.WriteLine("答はもっと小さいです");
                        b = score - 1;
                    }
                    else
                    {
                        Console.WriteLine("答はもっと大きいです");
                        a = score + 1;
                    }
                }
                Console.WriteLine(a + "から" + b + "の間の数値を当ててください。>");
                score = int.Parse(Console.ReadLine());
                count += 1;
            }
            Console.WriteLine("おめでとう。"+ count + "回目で当たりました。");
            Console.Write('\n');
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
