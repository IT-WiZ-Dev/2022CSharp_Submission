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
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 100;
            int targetNumber = random.Next(minNumber, maxNumber + 1);
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("1から100までの数を当ててください！");

            while (guess != targetNumber)
            {
                Console.Write($"予想した数を入力してください（{minNumber} から {maxNumber}）: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("無効な入力です。数値を入力してください。");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("もっと大きい数です！");
                    minNumber = guess + 1;
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("もっと小さい数です！");
                    maxNumber = guess - 1;
                }
                else
                {
                    Console.WriteLine("おめでとう.");
                    Console.WriteLine("試行回数: " + attempts +"回目で当たりました。");
                }

                if (minNumber > maxNumber)
                {
                    Console.WriteLine("ヒントの範囲が間違っています！");
                    break;
                }
            }

            Console.ReadLine();
        } 
    }
}
