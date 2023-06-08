using System;

class Program
{
    static void Main()
    {
        const int answer = 83;
        int minRange = 0;
        int maxRange = 100;
        int attempts = 0;

        Console.WriteLine("０から１００の間の数値を当ててください。");

        while (true)
        {
            Console.Write($"＞");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int guess) || guess < minRange || guess > maxRange)
            {
                Console.WriteLine("入力値が正しくありません。再入力してください。");
                continue;
            }

            attempts++;

            if (guess < answer)
            {
                Console.WriteLine($"答はもっと大きいです。\n{guess + 1}から{maxRange}の間の数値を当ててください。");
                minRange = guess + 1;
            }
            else if (guess > answer)
            {
                Console.WriteLine($"答はもっと小さいです。\n{minRange}から{guess - 1}の間の数値を当ててください。");
                maxRange = guess - 1;
            }
            else
            {
                Console.WriteLine($"おめでとう。{attempts}回目で当たりました。");
                break;
            }
        }

        Console.WriteLine("終了するには何かキーを押してください。");
        Console.Read();
    }
}
