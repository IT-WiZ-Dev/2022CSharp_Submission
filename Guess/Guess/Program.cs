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
            int targetNumber = random.Next(0, 101);
            int attempts = 0;


            while (true)
            {
                Console.Write("0から100の間の数値を当ててください。＞ ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    attempts++;

                    if (guess == targetNumber)
                    {
                        Console.WriteLine("おめでとう。 {0} 回目で当たりました。", attempts);
                        break;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("答はもっと大きいです。");
                    }
                    else
                    {
                        Console.WriteLine("答はもっと小さいです。");
                    }
                }
                else
                {
                    Console.WriteLine("正しい数値を入力してください。");
                }
            }

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.ReadLine();
        }
    }
}
