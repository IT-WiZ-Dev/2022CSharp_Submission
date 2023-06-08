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
            const int answer = 32;
            int result = 0;
            int min = 0;
            int max = 100;
            int count = 0;

            do
            {
                try
                {
                        Console.Write(min + "から" + max + "の間の数値を当ててください。＞");
                        result = int.Parse(Console.ReadLine());

                        if (result < min || max < result)
                        {
                            Console.WriteLine("入力値が正しくありません。再入力してください。");
                            continue;
                        }
                        else if (result > answer)
                        {
                            count++;
                            Console.WriteLine("答はもっと小さいです。");
                            Console.Write('\n');
                            max = result - 1;
                            continue;
                        }
                        else if (result < answer)
                        {
                            count++;
                            Console.WriteLine("答はもっと大きいです。");
                            Console.Write('\n');
                            min = result + 1;
                            continue;
                        }else if(result == answer)
                    {
                        count++;
                        Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                        Console.Write('\n');
                        Console.Write("終了するには何かキーを押してください。");
                        Console.Read();
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }
}
