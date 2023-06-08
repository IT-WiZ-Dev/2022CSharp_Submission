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
            int min = 0;
            int max = 100;
            int n;
            int k = 0;
            const int answer = 50;

            do
            {

                Console.Write(min + "から" + max + "の間の数値を当ててください。 ＞");
                n = int.Parse(Console.ReadLine());
                k++;

                if(n > answer)
                {
                    Console.WriteLine("答えはもっと小さいです。");
                    max -=(max - n)+1;
                    
                }
                else if(n < answer)
                {
                    Console.WriteLine("答えはもっと大きいです。");
                    min += (n + 1);
                }
                else if(n > max)
                {
                    Console.WriteLine("入力値が正しくありません");
                }
                else if(n < min)
                {
                    Console.WriteLine("入力値が正しくありません");
                }
                
                
               

            } while (n != answer);
            Console.WriteLine("おめでとう。" + k + "回目で当たりました");
            Console.Read();
        }
    }
}
