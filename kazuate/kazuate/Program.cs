using System;

class Program
{
    private const int MinNumber = 0;
    private const int MaxNumber = 100;

    static void Main()
    {
        // ゲームの設定
        Random random = new Random();
        int targetNumber = random.Next(MinNumber, MaxNumber + 1);
        int guess = 0;
        int attempts = 0;
        int minRange = MinNumber;
        int maxRange = MaxNumber;

        Console.WriteLine($"数当てゲームを始めます！{MinNumber}から{MaxNumber}までの数を当ててください。");

        // ユーザーの入力と判定
        while (guess != targetNumber)
        {
            Console.Write("予想した数を入力してください: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("無効な入力です。数値を入力してください。");
                continue;
            }

            if (guess < MinNumber || guess > MaxNumber)
            {
                Console.WriteLine($"範囲外の数です。{MinNumber}から{MaxNumber}の間の数を入力してください。");
                continue;
            }

            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("もっと大きな数です。");
                minRange = Math.Max(guess, minRange);
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("もっと小さな数です。");
                maxRange = Math.Min(guess, maxRange);
            }
            else
            {
                Console.WriteLine("正解です！おめでとうございます！");
                Console.WriteLine($"あなたの試行回数は {attempts} 回でした。");

                // 新しいゲームのために設定をリセット
                targetNumber = random.Next(MinNumber, MaxNumber + 1);
                attempts = 0;
                minRange = MinNumber;
                maxRange = MaxNumber;

                Console.WriteLine($"新しいゲームを始めます！{MinNumber}から{MaxNumber}までの数を当ててください。");
            }

            Console.WriteLine($"ヒント: 範囲は {minRange} から {maxRange} です。");
        }

        Console.WriteLine("ゲームを終了します。");
        Console.ReadLine();
    }
}
