using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数当てゲーム
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 58;
            int min = 0;
            int max = 100;
            int n1;
            int cnt = 0;
            try
            {
                do
                {
                    Console.Write(min + "から" + max + "の間の数値を当ててください＞");
                    n1 = int.Parse(Console.ReadLine());

                    if (n1 >= min && n1 <= max)
                    {
                        if (n1 > key)
                        {
                            max = n1;
                            Console.Write("答えはもっと小さいです");
                            cnt = cnt + 1;
                            Console.ReadLine();
                        }
                        else if(n1 < key)
                        {
                            min = n1;
                            Console.Write("答えはもっと大きいです");
                            cnt = cnt + 1;
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("入力値が正しくありません、再入力してください＞");
                        continue;
                    }

                } while (n1 != key);
                cnt = cnt + 1;
                Console.Write("おめでとう。" + cnt + "回目で当たりました。");
                Console.Write("終了するには何かキーを押してください");
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}
