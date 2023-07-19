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
            string input1 = Console.ReadLine();
            int number1;

            while (!int.TryParse(input1, out number1))
            {
            }

            string input2 = Console.ReadLine();
            int number2;
            while (!int.TryParse(input2, out number2))
            {
            }

            int sum = number1 + number2;


            Console.WriteLine(sum);
        }
    }
}

