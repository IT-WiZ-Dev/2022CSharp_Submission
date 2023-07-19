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

            int n1, n2;




            Console.Write("一つ目の数字");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("二つ目の数字");
            n2 = int.Parse(Console.ReadLine());


            Console.Write(n1 + n2);

            Console.Write('\n');
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }

    }
}

