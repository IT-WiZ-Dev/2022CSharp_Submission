using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章練習問題２
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = new Random().Next(0, 101);
            int minRange = 0;
            int maxRange = 100;
            int guessCount = 0;
            bool isCorrect = false;

            Console.WriteLine("あたりの数字を0～100の範囲で設定しました。");
            Console.WriteLine();

            while (!isCorrect)
            {
                Console.Write($"{minRange}～{maxRange}までの数字を当ててください: ");
                string input = Console.ReadLine();

                int guessedNumber;
                bool isNumeric = int.TryParse(input, out guessedNumber);

                if (!isNumeric || guessedNumber < minRange || guessedNumber > maxRange)
                {
                    Console.WriteLine("入力された値が範囲外です。もう一度入力してください。");
                    Console.WriteLine();
                    continue;
                }

                guessCount++;

                if (guessedNumber < targetNumber)
                {
                    Console.WriteLine("もっと大きな数です。");
                    minRange = guessedNumber + 1;
                }
                else if (guessedNumber > targetNumber)
                {
                    Console.WriteLine("もっと小さな数です。");
                    maxRange = guessedNumber - 1;
                }
                else
                {
                    isCorrect = true;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"おめでとうございます！正解です！{guessCount}回目で当たりました。");
        
    }
    }
}
