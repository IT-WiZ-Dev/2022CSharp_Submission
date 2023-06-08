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
            const int Answer = 50;
            int x;
            int y = 0;
            int z = 100;
            int count = 0;
            do
            {

                Console.Write(y + "から" + z + "の間の数値を当ててください。>");
                x = int.Parse(Console.ReadLine());
                if(x > z || x < y)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください");
                }else if(x < Answer)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    y = x + 1;
                }
                else if(x > Answer)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    z = x - 1;
                }
                
                count++;
            } while (x != Answer);
             Console.WriteLine("おめでとう。"+ count +"回目で当たりました。");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
