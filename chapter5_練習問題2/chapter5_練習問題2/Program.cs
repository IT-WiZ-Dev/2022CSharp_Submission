using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter5_練習問題2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(101);

            int min = 0;
            int max = 100;
           

            for (int i=1; i<=100; i++)
            {
                Console.WriteLine(min + "から" + max + "の間の数値を当ててください。" + ">");
                string a = Console.ReadLine();
                int answer = int.Parse(a);

                // 範囲外の入力チェック
                if(answer<min || answer > max)
                {
                    Console.WriteLine("入力値が正しくありません。　再入力してください。");
                    continue;
                }


                if (answer < n)
                {
                    Console.WriteLine("答はもっと大きいです");
                    min = answer + 1;
                }
                else if (answer > n)
                {
                    Console.WriteLine("答はもっと小さいです");
                    max = answer - 1;
                }
                else
                {
                    Console.WriteLine("おめでとうございます。" + i + "回目で当たりました。");
                    break;
                }

            }
            



        }
    }
}
