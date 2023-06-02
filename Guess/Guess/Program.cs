
using System;

class Program
{
    static void Main()
    {
        const int answer = 76; // 当たりの数
        int guess;
        int attempts = 0;

        Console.WriteLine("0から100の範囲の数を当ててください。");

        do
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            // 入力が数値かどうかを確認
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("数値を入力してください。");
                continue;
            }

            // 範囲外の数を入力した場合は再入力を求める
            if (guess < 0 || guess > 100)
            {
                Console.WriteLine("0から100の範囲で入力してください。");
                continue;
            }

            attempts++;

            if (guess > answer)
            {
                Console.WriteLine("答えはもっと小さいです。");
            }
            else if (guess < answer)
            {
                Console.WriteLine("答えはもっと大きいです。");
            }
            else
            {
                Console.WriteLine("正解です！ {0}回目で当たりました。", attempts);
            }

        } while (guess != answer);

        Console.ReadLine();
    }
}
