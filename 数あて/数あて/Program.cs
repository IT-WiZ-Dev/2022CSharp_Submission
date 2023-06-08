using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int targetNumber = random.Next(101); // 0から100の範囲であたりの数を生成
        int guessCount = 0; // ユーザーの回答回数
        int minNumber = 0; // 現在のヒント範囲の最小値
        int maxNumber = 100; // 現在のヒント範囲の最大値

        Console.WriteLine("数あてゲームを開始します！");
        Console.WriteLine($"0から100の間の数を当ててください。");

        while (true)
        {
            Console.Write($"範囲: {minNumber} ～ {maxNumber} 、数を入力してください: ");
            string input = Console.ReadLine();

            int userNumber;
            if (!int.TryParse(input, out userNumber))
            {
                Console.WriteLine("数値を入力してください。");
                continue;
            }

            if (userNumber < minNumber || userNumber > maxNumber)
            {
                Console.WriteLine("範囲外の数です。正しい範囲内の数を入力してください。");
                continue;
            }

            guessCount++;

            if (userNumber == targetNumber)
            {
                Console.WriteLine($"おめでとうございます！{guessCount}回目で当たりました！");
                break;
            }
            else if (userNumber < targetNumber)
            {
                Console.WriteLine("もっと大きい数です。");
                minNumber = userNumber + 1;
            }
            else
            {
                Console.WriteLine("もっと小さい数です。");
                maxNumber = userNumber - 1;
            }
        }

        Console.WriteLine("ゲームを終了します。");
        Console.ReadLine();
    }
}
