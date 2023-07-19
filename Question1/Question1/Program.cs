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
            using System;

namespace SimpleAddition
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    // コンソールから入力を受け取る
                    Console.Write("最初の値を入力してください: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("次の値を入力してください: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // 足し算して結果を計算
                    double result = num1 + num2;

                    // 結果を出力
                    Console.WriteLine("足し算の結果: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("有効な数値を入力してください。");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("入力された数値が大きすぎます。");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("エラーが発生しました: " + ex.Message);
                }
            }
        }
    }

}
    }
}
