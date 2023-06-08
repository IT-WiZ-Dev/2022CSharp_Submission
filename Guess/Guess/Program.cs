using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 0;
            int maxNumber = 100;
            int targetNumber;
            int attempts = 0;

            Random random = new Random();
            targetNumber = random.Next(minNumber, maxNumber + 1);

            Console.WriteLine("数当てゲームを開始します。");
            Console.WriteLine($"{minNumber}から{maxNumber}の間の数値を当ててください。");
            
            while (true)
            {
                Console.Write("予想した数を入力してください: ");
                string input = Console.ReadLine();
                int guess;

                if (!int.TryParse(input, out guess) || guess < minNumber || guess > maxNumber)
                {
                    Console.WriteLine("無効な入力です。範囲内の整数を入力してください。");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("答えはもっと大きいです。");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("答えはもっと小さいです。");
                }
                else
                {
                    Console.WriteLine("正解です！おめでとうございます！");
                    Console.WriteLine($"試行回数: {attempts}");
                    break;
                }
            }

            Console.WriteLine("ゲームを終了します。何かキーを押してください。");
            Console.ReadLine();
        }
    }
}
