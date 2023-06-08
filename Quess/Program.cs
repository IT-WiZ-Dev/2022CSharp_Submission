using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            Console.Write("0から100までの数を当ててください。");

            int guessCount = 0;
            int guessedNumber = 0;

            while (guessedNumber != targetNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guessedNumber))
                {
                    Console.Write("入力が無効です。数値を入力してください。");
                    continue;
                }

                guessCount++;

                if (guessedNumber < targetNumber)
                {
                    Console.WriteLine("もっと大きい数です。");
                }
                else if (guessedNumber > targetNumber)
                {
                    Console.WriteLine("もっと小さい数です。");
                }
                else
                {
                    Console.WriteLine($"おめでとうございます！{guessCount}回目で当たりました。");
                }
            }

            Console.WriteLine("ゲームを終了します。");
        }
    }
}
