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
            const int a = 77;
            int s,n  = 0;
            int low = 0;
            int high = 100;

            do
            {
                Console.Write(low +"から、" + high + "の間の数値を当ててください。>");
                s = int.Parse(Console.ReadLine());
                n++;

                if (s < low || s > high)
                {
                    Console.WriteLine("範囲外の数値です再入力してください。");
                    continue;
                }
                if (s > a)
                {
                    high = s;
                    Console.WriteLine("答えはもっと小さいです");
                    Console.Write(low + "から、" + high + "の間の数値を当ててください。>");
                    n++;
                }
                if (s < a)
                {
                    low = s;
                    Console.WriteLine("答えはもっと大きいです");
                    Console.Write(low + "から、" + high + "の間の数値を当ててください。>");
                    n++;
                }

            } while (s != a);
            Console.WriteLine("おめでとう。" + n + "回目で当たりました。");
            

            Console.Read();
        }
    }
}
