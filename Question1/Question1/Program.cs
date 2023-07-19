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
            int y,x,sum;
            string write;

            Console.WriteLine("１つ目の値の入力");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("2つ目の値の入力");
            y = int.Parse(Console.ReadLine());

            sum =  x + y;
            write = sum.ToString();
            Console.WriteLine("合計値の出力");
            Console.WriteLine(write);

            Console.Read();
        }
    }
}
