using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MinNumber = 0;
            const int MaxNumber = 100;

            Random random = new Random();
            int targetNumber = random.Next(MinNumber, MaxNumber + 1);

            int guessCount = 0;
            bool isCorrect = false;
            int previousGuess = -1;
            int currentMin = MinNumber;
            int currentMax = MaxNumber;

            Console.WriteLine($"{MinNumber}から{MaxNumber}の間の数値を当ててください。");

            while (!isCorrect)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("無効な入力です。整数を入力してください。");
                    continue;
                }

                if (guess < currentMin || guess > currentMax)
                {
                    Console.WriteLine($"範囲外の数です。{currentMin}から{currentMax}の範囲で入力してください。");
                    continue;
                }

                guessCount++;

                if (guess == previousGuess)
                {
                    Console.WriteLine("同じ数を入力しました。別の数を入力してください。");
                    continue;
                }

                if (guess < targetNumber)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    Console.WriteLine($"範囲は{guess + 1}から{currentMax}です。");
                    currentMin = guess + 1;
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    Console.WriteLine($"範囲は{currentMin}から{guess - 1}です。");
                    currentMax = guess - 1;
                }
                else
                {
                    isCorrect = true;
                    Console.WriteLine($"おめでとう。{guessCount}回目で当たりました。");
                }

                previousGuess = guess;
            }

            Console.ReadLine();
        }
    }
}
