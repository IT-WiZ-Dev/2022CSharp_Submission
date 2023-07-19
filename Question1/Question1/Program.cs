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
            Console.Write("");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("");
            double num2 = double.Parse(Console.ReadLine());


            double result = num1 + num2;

            Console.WriteLine(result);
        }
    }
}
