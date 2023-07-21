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
            {
                const int MinNum = 0;
                const int MaxNum = 100;

               
                int answer = 60;

                Console.WriteLine("", MinNum, MaxNum);

                int nyuryoku;
                bool sin = false;
                int a = 0;

                while (!sin)
                {
                    Console.Write(MinNum+"から"+MaxNum+"までの数値を当ててください。: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out nyuryoku) || nyuryoku < MinNum || nyuryoku > MaxNum)
                    {
                        Console.WriteLine("入力値が正しくありません。", MinNum, MaxNum);
                        continue;
                    }

                    a++;

                    if (nyuryoku < answer)
                    {
                        Console.WriteLine("答はもっと大きいです。。");

                    }
                    else if (nyuryoku > answer)
                    {
                        Console.WriteLine("答はもっと小さいです。");
                    }
                    else
                    {
                        sin = true;
                    }
                }

                Console.WriteLine("おめでとう。{1}回目で当たりました。", answer, a);
                Console.WriteLine("終了するには何かキーを押してください。");
                Console.Read();
            }
        }
    }
}
