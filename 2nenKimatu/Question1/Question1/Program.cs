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
 * 1
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
            Console.WriteLine("１つ目の数字を入力してください。");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("２つ目の数字を入力してください。");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("合計を算出します。");
            Console.WriteLine(num1 + num2);
        }
    }
}
