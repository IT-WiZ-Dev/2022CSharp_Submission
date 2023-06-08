using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int guess;
            int attempts = 0;
            int minRange = 0;
            int maxRange = 100;

            do
            {
                Console.Write(minRange + "から" + maxRange + "の間の数値を当ててください > ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    continue;
                }

                if (guess < minRange || guess > maxRange)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("答はもっと大きな数です。");
                    minRange = guess;
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("答はもっと小さな数です。");
                    maxRange = guess;
                }
                else
                {
                    Console.WriteLine("おめでとう。" + attempts + "回目で当てました。");
                    break;
                }

            } while (true);

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.ReadKey();
        }
    }
}
