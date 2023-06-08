using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\t\t***九九の表***\n");

        Console.Write("\t");
        for (int i = 1; i <= 9; i++)
        {
            Console.Write("{0}\t", i);
        }
        Console.WriteLine();
        Console.WriteLine();

        // 九九の表を作成
        for (int i = 1; i <= 9; i++)
        {
            Console.Write("{0}\t", i);
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("{0}\t", (i * j));
            }
            Console.WriteLine();
        }

        // キーの入力を待機してから終了
        Console.WriteLine("\nキーを押すと終了します。");
        Console.ReadKey();
    }
}

