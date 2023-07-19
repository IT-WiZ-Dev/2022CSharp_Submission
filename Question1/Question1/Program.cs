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
            Console.WriteLine("1つ目の数字を入力してください。");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("2つ目の数字を入力してください。");
            int y = int.Parse(Console.ReadLine());
            int z = x + y;
            Console.WriteLine($"結果は{z}です。");
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
