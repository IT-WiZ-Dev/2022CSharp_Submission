using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習問題５
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int answer = random.Next(101); // 0から100までのランダムな数を生成
            int attempts = 0;
            int guess = -1;

            Console.WriteLine("0～100までの数字を当ててください");

            while (guess != answer)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("無効な入力です。再度入力してください。");
                    continue;
                }

                if (guess < 0 || guess > 100)
                {
                    Console.WriteLine("範囲外の数字です。再度入力してください。");
                    continue;
                }

                attempts++;

                if (guess < answer)
                {
                    Console.WriteLine("もっと大きな数です");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("もっと小さな数です");
                }
            }

            Console.WriteLine("正解！ {0}回目で当たりました。", attempts);
            Console.ReadLine();
        }
    }
}
