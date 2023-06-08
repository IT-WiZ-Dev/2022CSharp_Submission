using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教科書第5章練習問題_Guess_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Atari = 39;
            int Max = 100;
            int Min = 0;
            int Count = 1;
            int n1;
            int Judge = 0;

            do
            {

                Console.Write(Min + "から" + Max + "の間の数値を当ててください。＞");
                n1 = int.Parse(Console.ReadLine());

                if (n1 < Min || n1 > Max)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Count = Count + 1;
                    continue;
                }

                else if (n1 > Atari)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    Max = n1 - 1;
                    Count = Count + 1;
                    continue;
                }
                else if (n1 < Atari)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    Min = n1 + 1;
                    Count = Count + 1;
                    continue;
                }
                else if (n1 == Atari)
                {
                    Console.WriteLine("おめでとう。" + Count + "回目で当たりました。");
                    Judge = Judge + 1;
                }
            } while (Judge != 1);
            Console.WriteLine("終了するには何かキーを押してください");
            Console.Read();
        }
    }
  }
    
