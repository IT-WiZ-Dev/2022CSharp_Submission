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
            int n;

            const int kotae = 32;
            int i = 1;
            int max = 100;
            int min = 0;

            do
            {
                Console.Write(min + "から" + max + "の間の数値を当ててください。＞ ");
                n = int.Parse(Console.ReadLine());

                if(n < min || n > max)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }


                if (n == kotae)
                {
                    Console.WriteLine("おめでとう。" + i + "回であたりました。");
                    Console.WriteLine(" ");
                }
                else if (n < kotae)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    Console.WriteLine(" ");
                    min = n + 1;
                    i = i + 1;
                }
                else if (n > kotae)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    Console.WriteLine(" ");
                    max = n - 1;
                    i = i + 1;
                }
            } while (n != kotae);


        }
    }
}
