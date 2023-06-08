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

            const int answer = 13;
            int count = 1;
            int high = 100;
            int low = 0;
            int n;

            do
            {
                Console.Write($"{low}から{high}の間の数値を当ててください。＞");
                Console.Write('\n');
                n = int.Parse(Console.ReadLine());

                if (n > high || n < low)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.Write('\n');
                }
                else if (n > answer)
                {
                    Console.WriteLine("答えはもっと小さいです。");
                    high = n - 1;
                    count = count + 1;
                    Console.Write('\n');
                }
                else if (n < answer)
                {
                    Console.WriteLine("答えはもっと大きいです。");
                    low = n + 1;
                    count = count + 1;
                    Console.Write('\n');
                }
            
            } while (n != answer);

            Console.WriteLine($"おめでとう。{count}回目で当たりました。");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();

        }
    }
}
