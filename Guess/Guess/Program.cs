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
            int ans = 32;
            int inp;
            int n = 0;
            int bottom = 0;
            int top = 100;

            do
            {
                n++;
                Console.Write(bottom + "から" + top + "までの間の数値を当ててください。 ＞");
                inp = int.Parse(Console.ReadLine());

                if(inp < bottom || inp > top)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.Write(bottom + "から" + top + "までの間の数値を当ててください。 ＞");
                    inp = int.Parse(Console.ReadLine());
                }

                if(inp < ans)
                {
                    Console.WriteLine("答えはもっと大きいです。");
                    bottom = inp;
                    Console.WriteLine();
                }
                else if (inp > ans)
                {
                    Console.WriteLine("答えはもっと小さいです。");
                    top =inp;
                    Console.WriteLine();
                }

            } while (ans != inp);

            if(ans == inp)
            {
                Console.WriteLine("おめでとう！" + n + "回目で当たりました。");

            }

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
