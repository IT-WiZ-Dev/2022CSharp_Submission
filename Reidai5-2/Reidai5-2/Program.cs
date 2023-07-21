using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reidai5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hiku = 0, taka = 100;
            int n, count = 1;
            const int kotae = 50;
            do
            {
                while (true)
                {
                    try
                    {
                        Console.Write("{0}から{1}の間の数値を当ててください。 ", hiku, taka);
                        n = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    if (n >= hiku && n <= taka)
                        break;
                    else
                        Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                if (n != kotae)
                {
                    count++;
                    if (n < kotae)
                    {
                        Console.WriteLine("答はもっと大きいです。\n");
                        hiku = n + 1;
                    }
                    else
                    {
                        Console.WriteLine("答はもっと小さいです。\n");
                        taka = n - 1;
                    }
                }
            } while (n != kotae);
            Console.WriteLine("おめでとう。{0}回目で当たりました。", count);
        
        }
    }
}
