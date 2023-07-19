using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問1
 * コンソール画面から入力された値を２つ受け取り、
 * 足し算した結果を出力（コンソール画面に表示）しなさい。
 * 
 * 入力例：
 * 15
 * 20
 * 
 * 出力例：
 * 35
 * 
*/


namespace Question1
{
    using System;

    class Program
    {
        static void Main()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;

            Console.WriteLine(sum);
        }
    }
}

