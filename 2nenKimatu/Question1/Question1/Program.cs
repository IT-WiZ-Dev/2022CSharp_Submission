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
            int x, y;

            Console.WriteLine("ひとつめの数字を入力してください");
            String inputString = Console.ReadLine();

            while (inputString != "quit")
            {

                x = Int32.Parse(inputString);

                Console.WriteLine("ふたつめの数字を入力してください");
                inputString = Console.ReadLine();
                y = Int32.Parse(inputString);

                Console.WriteLine("合計は" + (x + y) + "です");

                Console.WriteLine("ひとつめの数字を入力してください");
                inputString = Console.ReadLine();
            }
        }
    }
}
