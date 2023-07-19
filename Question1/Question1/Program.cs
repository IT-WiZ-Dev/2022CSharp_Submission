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
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("数値を2つ入力");

            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();
            int Num1 = Convert.ToInt32(a1);
            int Num2 = Convert.ToInt32(a2);

            int Num3 = Num1 + Num2;

            Console.WriteLine();

                Console.Write("合計:");
                Console.WriteLine(Num3.ToString());

                Console.ReadLine();
        }
    }
}
