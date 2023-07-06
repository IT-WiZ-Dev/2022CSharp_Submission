using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int guessCount = 0;
        int guess;

        Console.WriteLine("Up or Down ゲームを開始します！");
        Console.WriteLine("1から100までの数を当ててください。");

        do
        {
            Console.Write("予想した数を入力してください: ");
            string input = Console.ReadLine();

            // 入力値の検証
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("無効な入力です。数値を入力してください。");
                continue;
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("範囲外の数値です。1から100までの数を入力してください。");
                continue;
            }

            guessCount++;

            if (guess < targetNumber)
            {
                Console.WriteLine("Up!");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Down!");
            }
            else
            {
                Console.WriteLine($"正解です！{guessCount}回目で当たりました！");
                break;
            }
        } while (true);

        Console.WriteLine("ゲームを終了します。お疲れ様でした！");
        Console.ReadLine();
    }
}
