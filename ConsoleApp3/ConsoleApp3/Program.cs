using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int saidaiti = 100;
            int saisyouti = 0;
            int a = 79;
            int n1;
            int n = 1;

            do
            {
                Console.Write($"{saisyouti}から{saidaiti}の間の数値を当ててください<");
                n1 = int.Parse(Console.ReadLine());

                if(n1 > saidaiti || n1 < saisyouti)
                {
                    Console.WriteLine("入力値が正しくありません、再入力してください");

                }
                else if (n1 == a)
                {
                    Console.WriteLine($"おめでとう{n}回目に当たりました");
                }
                else if (n1 > a)
                {
                    Console.WriteLine("値はもっと小さいです");
                    saidaiti = n1 - 1;
                }
                else
                {
                    Console.WriteLine("値はもっと大きいです");
                    saisyouti = n1 + 1;
                }
                Console.WriteLine();
                n = n + 1;

            } while (a != n1);

            Console.WriteLine("終了するには何かキーを押してください");
            Console.Read();
        }
    }
}
