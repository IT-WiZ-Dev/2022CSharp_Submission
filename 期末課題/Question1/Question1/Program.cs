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
            Console.WriteLine("一つ目の値を入力");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("二つ目の値を入力");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("合計 : " + num3);
        }
    }
}
