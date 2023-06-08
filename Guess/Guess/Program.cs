using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 0; // 範囲の最小値
            int maxNumber = 100; // 範囲の最大値
            int targetNumber = new Random().Next(minNumber, maxNumber + 1); // あたりの数字
            int guessCount = 0; // 当たるまでの試行回数

            Console.WriteLine("0～100までの数字を当ててください");

            while (true)
            {
                Console.Write("＞");
                string input = Console.ReadLine();

                int guess;
                bool isValidInput = int.TryParse(input, out guess);

                if (!isValidInput || guess < minNumber || guess > maxNumber)
                {
                    Console.WriteLine("無効な入力です。0～100までの数字を入力してください。");
                    continue;
                }

                guessCount++;

                if (guess < targetNumber)
                {
                    minNumber = guess + 1;
                    Console.WriteLine("{0}より大きい数を当ててください", guess);
                }
                else if (guess > targetNumber)
                {
                    maxNumber = guess - 1;
                    Console.WriteLine("{0}より小さい数を当ててください", guess);
                }
                else
                {
                    Console.WriteLine("正解！{0}回目で当たりました。", guessCount);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
