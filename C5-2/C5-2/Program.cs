using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Answer = 37;
            int low = 0, high = 100;
            int n, count = 1;

            do
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"{low}から{high}の間の数値を当ててください。＞ ");
                        n = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                         goto END;
                    }
                    if (n >= low && n <= high)
                        break;
                    else
                        Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                if (n != Answer)
                {
                    count++;
                    if (n < Answer)
                    {
                        Console.WriteLine("答はもっと大きいです。\n");
                        low = n + 1;
                    }
                    else
                    {
                        Console.WriteLine("答はもっと小さいです。\n");
                        high = n - 1;
                    }
                }
            } while (n != Answer);
            Console.WriteLine($"おめでとう。{count}回目で当たりました。");

        END:
            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
        
    

