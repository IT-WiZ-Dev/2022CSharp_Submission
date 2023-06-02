using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ansNum = 20;
            int minNum = 0;
            int maxNum = 100;
            int response;
            int cnt = 1;
            while (true)
            {
                Console.Write($"{minNum}から{maxNum}の間の数値を当ててください。＞ ");
                response = int.Parse(Console.ReadLine());
                if(ansNum == response)
                {
                    break;
                }
                if(minNum > response || maxNum < response)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                else if(response > ansNum)
                {
                    cnt++;
                    maxNum = response - 1;
                    Console.WriteLine("答はもっと小さいです。");
                }
                else
                {
                    cnt++;
                    minNum = response + 1;
                    Console.WriteLine("答はもっと大きいです。");
                }           
            }
            Console.WriteLine($"おめでとう。{cnt}回目で当たりました。");
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
