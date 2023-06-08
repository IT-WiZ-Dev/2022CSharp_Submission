using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        const int TargetNumber = 42; // 当たりの数
        static void Main(string[] args)
        {
            Console.WriteLine("数当てゲームを開始します！");
            Console.WriteLine("0から100の範囲の数を当ててください。");

            int attempts = 0; // 試行回数

            while (true)
            {
                Console.Write("数を入力してください: ");
                string input = Console.ReadLine();

                int guess;
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("数を正しく入力してください。");
                    continue;
                }

                if (guess < 0 || guess > 100)
                {
                    Console.WriteLine("0から100の範囲で入力してください。");
                    continue;
                }

                attempts++;

                if (guess == TargetNumber)
                {
                    Console.WriteLine("当たりです！おめでとうございます！");
                    Console.WriteLine($"試行回数: {attempts}");
                    break;
                }
                else if (guess < TargetNumber)
                {
                    Console.WriteLine("もっと大きい数です。");
                }
                else
                {
                    Console.WriteLine("もっと小さい数です。");
                }
            }

            Console.ReadKey();
        }
    }
}


