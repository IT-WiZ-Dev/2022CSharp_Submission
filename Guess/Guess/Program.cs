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


            const int i = 7;//当たりの数
            int min = 0, max = 100, num = 0;
            Console.WriteLine("0から100の間の数値を当ててください。>");
            int score = int.Parse(Console.ReadLine());//入力された文字列を整数型に変換
            while (score != i)//入力した値がiと一致しなければ繰り返す
            {
                if (score > i && score <= max)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    max = score - 1;
                    num++;
                    Console.WriteLine('\n');
                    Console.WriteLine(min + "から" + max + "の間の数値を当ててください。>");
                    score = int.Parse(Console.ReadLine());
                }
                else if (score < i && score >= min)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    min = score + 1;
                    num++;
                    Console.WriteLine('\n');
                    Console.WriteLine(min + "から" + max + "の間の数値を当ててください。>");
                    score = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    num++;
                    score = int.Parse(Console.ReadLine());
                }
            }
            num++;
            Console.WriteLine("おめでとう。" + num + "回目で当たりました。");
            Console.WriteLine('\n');
            Console.WriteLine("終了するにはEnterキーを押してください。");
            Console.ReadLine();
        }
    }
}
